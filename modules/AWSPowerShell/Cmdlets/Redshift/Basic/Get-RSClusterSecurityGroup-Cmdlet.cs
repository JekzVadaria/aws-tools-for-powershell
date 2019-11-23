/*******************************************************************************
 *  Copyright 2012-2019 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *
 *  AWS Tools for Windows (TM) PowerShell (TM)
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using Amazon.PowerShell.Common;
using Amazon.Runtime;
using Amazon.Redshift;
using Amazon.Redshift.Model;

namespace Amazon.PowerShell.Cmdlets.RS
{
    /// <summary>
    /// Returns information about Amazon Redshift security groups. If the name of a security
    /// group is specified, the response will contain only information about only that security
    /// group.
    /// 
    ///  
    /// <para>
    ///  For information about managing security groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
    /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Cluster Management
    /// Guide</i>.
    /// </para><para>
    /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
    /// all security groups that match any combination of the specified keys and values. For
    /// example, if you have <code>owner</code> and <code>environment</code> for tag keys,
    /// and <code>admin</code> and <code>test</code> for tag values, all security groups that
    /// have any combination of those values are returned.
    /// </para><para>
    /// If both tag keys and values are omitted from the request, security groups are returned
    /// regardless of whether they have tag keys or values associated with them.
    /// </para><br/><br/>This cmdlet automatically pages all available results to the pipeline - parameters related to iteration are only needed if you want to manually control the paginated output. To disable autopagination, use -NoAutoIteration.
    /// </summary>
    [Cmdlet("Get", "RSClusterSecurityGroup")]
    [OutputType("Amazon.Redshift.Model.ClusterSecurityGroup")]
    [AWSCmdlet("Calls the Amazon Redshift DescribeClusterSecurityGroups API operation.", Operation = new[] {"DescribeClusterSecurityGroups"}, SelectReturnType = typeof(Amazon.Redshift.Model.DescribeClusterSecurityGroupsResponse), LegacyAlias="Get-RSClusterSecurityGroups")]
    [AWSCmdletOutput("Amazon.Redshift.Model.ClusterSecurityGroup or Amazon.Redshift.Model.DescribeClusterSecurityGroupsResponse",
        "This cmdlet returns a collection of Amazon.Redshift.Model.ClusterSecurityGroup objects.",
        "The service call response (type Amazon.Redshift.Model.DescribeClusterSecurityGroupsResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetRSClusterSecurityGroupCmdlet : AmazonRedshiftClientCmdlet, IExecutor
    {
        
        #region Parameter ClusterSecurityGroupName
        /// <summary>
        /// <para>
        /// <para>The name of a cluster security group for which you are requesting details. You can
        /// specify either the <b>Marker</b> parameter or a <b>ClusterSecurityGroupName</b> parameter,
        /// but not both. </para><para> Example: <code>securitygroup1</code></para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        public System.String ClusterSecurityGroupName { get; set; }
        #endregion
        
        #region Parameter TagKey
        /// <summary>
        /// <para>
        /// <para>A tag key or keys for which you want to return all matching cluster security groups
        /// that are associated with the specified key or keys. For example, suppose that you
        /// have security groups that are tagged with keys called <code>owner</code> and <code>environment</code>.
        /// If you specify both of these tag keys in the request, Amazon Redshift returns a response
        /// with the security groups that have either or both of these tag keys associated with
        /// them.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("TagKeys")]
        public System.String[] TagKey { get; set; }
        #endregion
        
        #region Parameter TagValue
        /// <summary>
        /// <para>
        /// <para>A tag value or values for which you want to return all matching cluster security groups
        /// that are associated with the specified tag value or values. For example, suppose that
        /// you have security groups that are tagged with values called <code>admin</code> and
        /// <code>test</code>. If you specify both of these tag values in the request, Amazon
        /// Redshift returns a response with the security groups that have either or both of these
        /// tag values associated with them.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("TagValues")]
        public System.String[] TagValue { get; set; }
        #endregion
        
        #region Parameter Marker
        /// <summary>
        /// <para>
        /// <para>An optional parameter that specifies the starting point to return a set of response
        /// records. When the results of a <a>DescribeClusterSecurityGroups</a> request exceed
        /// the value specified in <code>MaxRecords</code>, AWS returns a value in the <code>Marker</code>
        /// field of the response. You can retrieve the next set of response records by providing
        /// the returned marker value in the <code>Marker</code> parameter and retrying the request.
        /// </para><para>Constraints: You can specify either the <b>ClusterSecurityGroupName</b> parameter
        /// or the <b>Marker</b> parameter, but not both. </para>
        /// </para>
        /// <para>
        /// <br/><b>Note:</b> This parameter is only used if you are manually controlling output pagination of the service API call.
        /// <br/>In order to manually control output pagination, use '-Marker $null' for the first call and '-Marker $AWSHistory.LastServiceResponse.Marker' for subsequent calls.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("NextToken")]
        public System.String Marker { get; set; }
        #endregion
        
        #region Parameter MaxRecord
        /// <summary>
        /// <para>
        /// <para>The maximum number of response records to return in each call. If the number of remaining
        /// response records exceeds the specified <code>MaxRecords</code> value, a value is returned
        /// in a <code>marker</code> field of the response. You can retrieve the next set of records
        /// by retrying the command with the returned marker value. </para><para>Default: <code>100</code></para><para>Constraints: minimum 20, maximum 100.</para>
        /// </para>
        /// <para>
        /// <br/><b>Note:</b> In AWSPowerShell and AWSPowerShell.NetCore this parameter is used to limit the total number of items returned by the cmdlet.
        /// <br/>In AWS.Tools this parameter is simply passed to the service to specify how many items should be returned by each service call.
        /// <br/>Pipe the output of this cmdlet into Select-Object -First to terminate retrieving data pages early and control the number of items returned.
        /// </para>
        /// <para>If a value for this parameter is not specified the cmdlet will use a default value of '<b>100</b>'.</para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("MaxItems","MaxRecords")]
        public int? MaxRecord { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'ClusterSecurityGroups'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Redshift.Model.DescribeClusterSecurityGroupsResponse).
        /// Specifying the name of a property of type Amazon.Redshift.Model.DescribeClusterSecurityGroupsResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "ClusterSecurityGroups";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the ClusterSecurityGroupName parameter.
        /// The -PassThru parameter is deprecated, use -Select '^ClusterSecurityGroupName' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^ClusterSecurityGroupName' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        #region Parameter NoAutoIteration
        /// <summary>
        /// By default the cmdlet will auto-iterate and retrieve all results to the pipeline by performing multiple
        /// service calls. If set, the cmdlet will retrieve only the next 'page' of results using the value of Marker
        /// as the start point.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter NoAutoIteration { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Redshift.Model.DescribeClusterSecurityGroupsResponse, GetRSClusterSecurityGroupCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.ClusterSecurityGroupName;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.ClusterSecurityGroupName = this.ClusterSecurityGroupName;
            context.Marker = this.Marker;
            if (ParameterWasBound(nameof(this.MaxRecord)))
            {
                context.MaxRecord = this.MaxRecord;
            }
            #if MODULAR
            else
            {
                WriteVerbose("MaxRecord parameter unset, using default value of '100'");
                context.MaxRecord = 100;
            }
            #endif
            #if !MODULAR
            if (ParameterWasBound(nameof(this.MaxRecord)) && this.MaxRecord.HasValue)
            {
                WriteWarning("AWSPowerShell and AWSPowerShell.NetCore use the MaxRecord parameter to limit the total number of items returned by the cmdlet." +
                    " This behavior is obsolete and will be removed in a future version of these modules. Pipe the output of this cmdlet into Select-Object -First to terminate" +
                    " retrieving data pages early and control the number of items returned. AWS.Tools already implements the new behavior of simply passing MaxRecord" +
                    " to the service to specify how many items should be returned by each service call.");
            }
            #endif
            if (this.TagKey != null)
            {
                context.TagKey = new List<System.String>(this.TagKey);
            }
            if (this.TagValue != null)
            {
                context.TagValue = new List<System.String>(this.TagValue);
            }
            
            // allow further manipulation of loaded context prior to processing
            PostExecutionContextLoad(context);
            
            var output = Execute(context) as CmdletOutput;
            ProcessOutput(output);
        }
        
        #region IExecutor Members
        
        #if MODULAR
        public object Execute(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            var useParameterSelect = this.Select.StartsWith("^") || this.PassThru.IsPresent;
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            
            // create request and set iteration invariants
            var request = new Amazon.Redshift.Model.DescribeClusterSecurityGroupsRequest();
            
            if (cmdletContext.ClusterSecurityGroupName != null)
            {
                request.ClusterSecurityGroupName = cmdletContext.ClusterSecurityGroupName;
            }
            if (cmdletContext.MaxRecord != null)
            {
                request.MaxRecords = AutoIterationHelpers.ConvertEmitLimitToServiceTypeInt32(cmdletContext.MaxRecord.Value);
            }
            if (cmdletContext.TagKey != null)
            {
                request.TagKeys = cmdletContext.TagKey;
            }
            if (cmdletContext.TagValue != null)
            {
                request.TagValues = cmdletContext.TagValue;
            }
            
            // Initialize loop variant and commence piping
            var _nextToken = cmdletContext.Marker;
            var _userControllingPaging = this.NoAutoIteration.IsPresent || ParameterWasBound(nameof(this.Marker));
            
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            do
            {
                request.Marker = _nextToken;
                
                CmdletOutput output;
                
                try
                {
                    
                    var response = CallAWSServiceOperation(client, request);
                    
                    object pipelineOutput = null;
                    if (!useParameterSelect)
                    {
                        pipelineOutput = cmdletContext.Select(response, this);
                    }
                    output = new CmdletOutput
                    {
                        PipelineOutput = pipelineOutput,
                        ServiceResponse = response
                    };
                    
                    _nextToken = response.Marker;
                }
                catch (Exception e)
                {
                    output = new CmdletOutput { ErrorResponse = e };
                }
                
                ProcessOutput(output);
                
            } while (!_userControllingPaging && AutoIterationHelpers.HasValue(_nextToken));
            
            if (useParameterSelect)
            {
                WriteObject(cmdletContext.Select(null, this));
            }
            
            
            return null;
        }
        #else
        public object Execute(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;
            var useParameterSelect = this.Select.StartsWith("^") || this.PassThru.IsPresent;
            
            // create request and set iteration invariants
            var request = new Amazon.Redshift.Model.DescribeClusterSecurityGroupsRequest();
            if (cmdletContext.ClusterSecurityGroupName != null)
            {
                request.ClusterSecurityGroupName = cmdletContext.ClusterSecurityGroupName;
            }
            if (cmdletContext.TagKey != null)
            {
                request.TagKeys = cmdletContext.TagKey;
            }
            if (cmdletContext.TagValue != null)
            {
                request.TagValues = cmdletContext.TagValue;
            }
            
            // Initialize loop variants and commence piping
            System.String _nextToken = null;
            int? _emitLimit = null;
            int _retrievedSoFar = 0;
            if (AutoIterationHelpers.HasValue(cmdletContext.Marker))
            {
                _nextToken = cmdletContext.Marker;
            }
            if (AutoIterationHelpers.HasValue(cmdletContext.MaxRecord))
            {
                // The service has a maximum page size of 100. If the user has
                // asked for more items than page max, and there is no page size
                // configured, we rely on the service ignoring the set maximum
                // and giving us 100 items back. If a page size is set, that will
                // be used to configure the pagination.
                // We'll make further calls to satisfy the user's request.
                _emitLimit = cmdletContext.MaxRecord;
            }
            var _userControllingPaging = this.NoAutoIteration.IsPresent || ParameterWasBound(nameof(this.Marker));
            
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            do
            {
                request.Marker = _nextToken;
                if (_emitLimit.HasValue)
                {
                    int correctPageSize = AutoIterationHelpers.Min(100, _emitLimit.Value);
                    request.MaxRecords = AutoIterationHelpers.ConvertEmitLimitToInt32(correctPageSize);
                }
                else
                {
                    request.MaxRecords = AutoIterationHelpers.ConvertEmitLimitToInt32(100);
                }
                
                CmdletOutput output;
                
                try
                {
                    
                    var response = CallAWSServiceOperation(client, request);
                    object pipelineOutput = null;
                    if (!useParameterSelect)
                    {
                        pipelineOutput = cmdletContext.Select(response, this);
                    }
                    output = new CmdletOutput
                    {
                        PipelineOutput = pipelineOutput,
                        ServiceResponse = response
                    };
                    int _receivedThisCall = response.ClusterSecurityGroups.Count;
                    
                    _nextToken = response.Marker;
                    _retrievedSoFar += _receivedThisCall;
                    if (_emitLimit.HasValue)
                    {
                        _emitLimit -= _receivedThisCall;
                    }
                }
                catch (Exception e)
                {
                    if (_retrievedSoFar == 0 || !_emitLimit.HasValue)
                    {
                        output = new CmdletOutput { ErrorResponse = e };
                    }
                    else
                    {
                        break;
                    }
                }
                
                ProcessOutput(output);
            } while (!_userControllingPaging && AutoIterationHelpers.HasValue(_nextToken) && (!_emitLimit.HasValue || _emitLimit.Value >= 1));
            
            
            if (useParameterSelect)
            {
                WriteObject(cmdletContext.Select(null, this));
            }
            
            
            return null;
        }
        #endif
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.Redshift.Model.DescribeClusterSecurityGroupsResponse CallAWSServiceOperation(IAmazonRedshift client, Amazon.Redshift.Model.DescribeClusterSecurityGroupsRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Redshift", "DescribeClusterSecurityGroups");
            try
            {
                #if DESKTOP
                return client.DescribeClusterSecurityGroups(request);
                #elif CORECLR
                return client.DescribeClusterSecurityGroupsAsync(request).GetAwaiter().GetResult();
                #else
                        #error "Unknown build edition"
                #endif
            }
            catch (AmazonServiceException exc)
            {
                var webException = exc.InnerException as System.Net.WebException;
                if (webException != null)
                {
                    throw new Exception(Utils.Common.FormatNameResolutionFailureMessage(client.Config, webException.Message), webException);
                }
                throw;
            }
        }
        
        #endregion
        
        internal partial class CmdletContext : ExecutorContext
        {
            public System.String ClusterSecurityGroupName { get; set; }
            public System.String Marker { get; set; }
            public int? MaxRecord { get; set; }
            public List<System.String> TagKey { get; set; }
            public List<System.String> TagValue { get; set; }
            public System.Func<Amazon.Redshift.Model.DescribeClusterSecurityGroupsResponse, GetRSClusterSecurityGroupCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.ClusterSecurityGroups;
        }
        
    }
}