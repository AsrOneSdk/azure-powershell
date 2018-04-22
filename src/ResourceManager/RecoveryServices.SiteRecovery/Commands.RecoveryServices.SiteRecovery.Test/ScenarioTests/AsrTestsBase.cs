// ----------------------------------------------------------------------------------
// 
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using Microsoft.Azure.Commands.Common.Authentication;
using Microsoft.Azure.Management.Internal.Resources;
using Microsoft.Azure.Management.RecoveryServices;
using Microsoft.Azure.Management.RecoveryServices.SiteRecovery;
using Microsoft.Azure.Test;
using Microsoft.Azure.Test.HttpRecorder;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Microsoft.WindowsAzure.Commands.Test.Utilities.Common;
using RestTestFramework = Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using Microsoft.Azure.Commands.Common.Authentication.Abstractions;

namespace RecoveryServices.SiteRecovery.Test
{
    public abstract class AsrTestsBase : RMTestBase
    {
        protected string vaultSettingsFilePath;
        protected string powershellFile;
        private string asrVaultCreds;
        private CSMTestEnvironmentFactory csmTestFactory;
        private EnvironmentSetupHelper helper;

        protected AsrTestsBase()
        {
        }

        protected void initialize()
        {

            this.helper = new EnvironmentSetupHelper();
        }

        public ResourceManagementClient RmRestClient { get; private set; }
        public RecoveryServicesClient RecoveryServicesMgmtClient { get; private set; }
        public SiteRecoveryManagementClient SiteRecoveryMgmtClient { get; private set; }

        public void RunPowerShellTest(
            string scenario,
            params string[] scripts)
        {
            var callingClassType = TestUtilities.GetCallingClass(2);
            var mockName = TestUtilities.GetCurrentMethodName(2);

            this.RunPsTestWorkflow(
                scenario,
                () => scripts,

                // no custom initializer
                null,

                // no custom cleanup 
                null,
                callingClassType,
                mockName);
        }

        public void RunPsTestWorkflow(
            string scenario,
            Func<string[]> scriptBuilder,
            Action<CSMTestEnvironmentFactory> initialize,
            Action cleanup,
            string callingClassType,
            string mockName)
        {
            var providers = new Dictionary<string, string>();
            providers.Add(
                "Microsoft.Resources",
                null);
            providers.Add(
                "Microsoft.Features",
                null);
            providers.Add(
                "Microsoft.Authorization",
                null);
            providers.Add(
                "Microsoft.Compute",
                null);
            var providersToIgnore = new Dictionary<string, string>();
            providersToIgnore.Add(
                "Microsoft.Azure.Management.Resources.ResourceManagementClient",
                "2016-02-01");
            HttpMockServer.Matcher = new PermissiveRecordMatcherWithApiExclusion(
                true,
                providers,
                providersToIgnore);

            HttpMockServer.RecordsDirectory = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "SessionRecords");

            using (var context = RestTestFramework.MockContext.Start(
                callingClassType,
                mockName))
            {
                this.csmTestFactory = new CSMTestEnvironmentFactory();

                if (initialize != null)
                {
                    initialize.Invoke(this.csmTestFactory);
                }

                this.SetupManagementClients(
                    scenario,
                    context);

                this.helper.SetupEnvironment(AzureModule.AzureResourceManager);

                var rmProfileModule = this.helper.RMProfileModule;
                var rmModulePath =
                    this.helper.GetRMModulePath("AzureRM.RecoveryServices.SiteRecovery.psd1");
                var recoveryServicesModulePath =
                    this.helper.GetRMModulePath("AzureRM.RecoveryServices.psd1");

                var modules = new List<string>();

                modules.Add(powershellFile);
                modules.Add(rmProfileModule);
                modules.Add(rmModulePath);
                modules.Add(recoveryServicesModulePath);

                this.helper.SetupModules(
                    AzureModule.AzureResourceManager,
                    modules.ToArray());

                try
                {
                    if (scriptBuilder != null)
                    {
                        var psScripts = scriptBuilder();

                        if (psScripts != null)
                        {
                            this.helper.RunPowerShellTest(psScripts);
                        }
                    }
                }
                finally
                {
                    if (cleanup != null)
                    {
                        cleanup.Invoke();
                    }
                }
            }
        }

        protected void SetupManagementClients(
            string scenario,
            RestTestFramework.MockContext context)
        {
            this.RmRestClient = this.GetRmRestClient(context);
            this.RecoveryServicesMgmtClient = this.GetRecoveryServicesManagementClient(context);
            this.SiteRecoveryMgmtClient = this.GetSiteRecoveryManagementClient(
                scenario,
                context);
            this.helper.SetupManagementClients(
                this.RmRestClient,
                this.RecoveryServicesMgmtClient,
                this.SiteRecoveryMgmtClient);
        }

        private RecoveryServicesClient GetRecoveryServicesManagementClient(
            RestTestFramework.MockContext context)
        {
            return context.GetServiceClient<RecoveryServicesClient>(
                RestTestFramework.TestEnvironmentFactory.GetTestEnvironment());
        }

        private ResourceManagementClient GetRmRestClient(
            RestTestFramework.MockContext context)
        {
            return context.GetServiceClient<ResourceManagementClient>(
                RestTestFramework.TestEnvironmentFactory.GetTestEnvironment());
        }

        private SiteRecoveryManagementClient GetSiteRecoveryManagementClient(
            string scenario,
            RestTestFramework.MockContext context)
        {
            var client = this.GetSiteRecoveryManagementClient(context);

            return client;
        }

        private SiteRecoveryManagementClient GetSiteRecoveryManagementClient(
            RestTestFramework.MockContext context)
        {
            return context.GetServiceClient<SiteRecoveryManagementClient>(
                RestTestFramework.TestEnvironmentFactory.GetTestEnvironment());
        }

        private static bool IgnoreCertificateErrorHandler(
            object sender,
            X509Certificate certificate,
            X509Chain chain,
            SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
    }
}
