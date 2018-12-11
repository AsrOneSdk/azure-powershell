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

using Xunit;
using Xunit.Abstractions;
using Microsoft.Azure.ServiceManagemenet.Common.Models;
using Microsoft.WindowsAzure.Commands.ScenarioTest;


namespace RecoveryServices.SiteRecovery.Test
{
    public class AsrE2ATests : AsrTestsBase
    {
        public XunitTracingInterceptor _logger;
        public AsrE2ATests(
            ITestOutputHelper output)
        {
            _logger = new XunitTracingInterceptor(output);
            XunitTracingInterceptor.AddToContext(_logger);
            this.vaultSettingsFilePath = System.IO.Path.Combine(
                System.AppDomain.CurrentDomain.BaseDirectory,
                "ScenarioTests\\E2A\\E2A.VaultCredentials");
            this.powershellFile = System.IO.Path.Combine(
                System.AppDomain.CurrentDomain.BaseDirectory,
                "ScenarioTests\\E2A\\AsrE2ATests.ps1");
            this.initialize();
        }

        
        [Trait(
            Category.AcceptanceType,
            Category.CheckIn)]
        public void FabricTests()
        {
            this.RunPowerShellTest(
                _logger,
                Constants.NewModel,
                "Test-FabricTest -vaultSettingsFilePath \"" +
                this.vaultSettingsFilePath +
                "\"");
        }

        
        [Trait(
            Category.AcceptanceType,
            Category.CheckIn)]
        public void TestCreatePolicy()
        {
            this.RunPowerShellTest(
                _logger,
                Constants.NewModel,
                "Test-SiteRecoveryCreatePolicy -vaultSettingsFilePath \"" +
                this.vaultSettingsFilePath +
                "\"");
        }

        
        [Trait(
            Category.AcceptanceType,
            Category.CheckIn)]
        public void TestEnableDR()
        {
            this.RunPowerShellTest(
                _logger,
                Constants.NewModel,
                "Test-SiteRecoveryEnableDR -vaultSettingsFilePath \"" +
                this.vaultSettingsFilePath +
                "\"");
        }

        
        [Trait(
            Category.AcceptanceType,
            Category.CheckIn)]
        public void TestMapNetwork()
        {
            this.RunPowerShellTest(
                _logger,
                Constants.NewModel,
                "Test-MapNetwork -vaultSettingsFilePath \"" +
                this.vaultSettingsFilePath +
                "\"");
        }

        
        [Trait(
            Category.AcceptanceType,
            Category.CheckIn)]
        public void TestTFO()
        {
            this.RunPowerShellTest(
                _logger,
                Constants.NewModel,
                "Test-TFO -vaultSettingsFilePath \"" +
                this.vaultSettingsFilePath +
                "\"");
        }

        
        [Trait(
            Category.AcceptanceType,
            Category.CheckIn)]
        public void TestPlannedFailover()
        {
            this.RunPowerShellTest(
                _logger,
                Constants.NewModel,
                "Test-PlannedFailover -vaultSettingsFilePath \"" +
                this.vaultSettingsFilePath +
                "\"");
        }

        
        [Trait(
            Category.AcceptanceType,
            Category.CheckIn)]
        public void TestReprotect()
        {
            this.RunPowerShellTest(
                _logger,
                Constants.NewModel,
                "Test-Reprotect -vaultSettingsFilePath \"" +
                this.vaultSettingsFilePath +
                "\"");
        }
    }
}
