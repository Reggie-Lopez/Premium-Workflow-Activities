using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Activities;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;
using Microsoft.Crm.Sdk.Messages;

namespace Premium_Workflow_Activities.Plugins
{
    public partial class PremiumWorkflowActivities : BaseWorkflow
    {
        // This is an example argument
        [RequiredArgument]
        [Input("Select an email to send")]
        [ReferenceTarget("email")]
        public InArgument<EntityReference> EmailReference { get; set; }
        
        protected override void ExecuteInternal(LocalWorkflowContext context)
        {
            // Todo: implement your logic here
            var emailRef = this.EmailReference.Get(context.CodeActivityContext);

        }
    }
}

