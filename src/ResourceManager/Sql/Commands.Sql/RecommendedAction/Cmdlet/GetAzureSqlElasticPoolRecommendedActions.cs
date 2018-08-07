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

using Microsoft.Azure.Commands.Sql.RecommendedAction.Model;
using System.Collections.Generic;
using System.Management.Automation;
using Microsoft.PowerShell.Commands;

namespace Microsoft.Azure.Commands.Sql.RecommendedAction.Cmdlet
{
    /// <summary>
    /// Defines the Get-AzureRmSqlElasticPoolRecommendedActions cmdlet
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "AzureRmSqlElasticPoolRecommendedAction")]
    [OutputType(typeof(AzureSqlElasticPoolRecommendedActionModel))]
    public class GetAzureSqlElasticPoolRecommendedAction : AzureSqlElasticPoolRecommendedActionCmdletBase
    {
        /// <summary>
        /// Gets or sets the name of the recommended action.
        /// </summary>
        [Parameter(Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Azure SQL Elastic Pool Recommended Action name.")]
        [ValidateNotNullOrEmpty]
        public string RecommendedActionName { get; set; }

        /// <summary>
        /// Gets entities from the service.
        /// </summary>
        /// <returns>A list of entities</returns>
        protected override IEnumerable<AzureSqlElasticPoolRecommendedActionModel> GetEntity()
        {
            ICollection<AzureSqlElasticPoolRecommendedActionModel> results;

            if (MyInvocation.BoundParameters.ContainsKey("RecommendedActionName"))
            {
                results = new List<AzureSqlElasticPoolRecommendedActionModel>();
                results.Add(ModelAdapter.GetElasticPoolRecommendedAction(this.ResourceGroupName, this.ServerName, this.ElasticPoolName, this.AdvisorName, this.RecommendedActionName));
            }
            else
            {
                results = ModelAdapter.ListElasticPoolRecommendedActions(this.ResourceGroupName, this.ServerName, this.ElasticPoolName, this.AdvisorName);
            }

            return results;
        }

        /// <summary>
        /// No user input to apply to model
        /// </summary>
        /// <param name="model">Model retrieved from service</param>
        /// <returns>The model that was passed in</returns>
        protected override IEnumerable<AzureSqlElasticPoolRecommendedActionModel> ApplyUserInputToModel(IEnumerable<AzureSqlElasticPoolRecommendedActionModel> model)
        {
            return model;
        }

        /// <summary>
        /// No changes to persist to server
        /// </summary>
        /// <param name="entity">The output of apply user input to model</param>
        /// <returns>The input entity</returns>
        protected override IEnumerable<AzureSqlElasticPoolRecommendedActionModel> PersistChanges(IEnumerable<AzureSqlElasticPoolRecommendedActionModel> entity)
        {
            return entity;
        }
    }
}
