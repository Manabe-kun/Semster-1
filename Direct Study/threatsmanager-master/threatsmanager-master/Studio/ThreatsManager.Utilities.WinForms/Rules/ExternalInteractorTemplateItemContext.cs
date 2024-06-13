﻿using System.Linq;
using DevComponents.AdvTree;
using PostSharp.Patterns.Contracts;
using ThreatsManager.AutoGenRules.Engine;
using ThreatsManager.Interfaces.ObjectModel;
using ThreatsManager.Interfaces.ObjectModel.Entities;

namespace ThreatsManager.Utilities.WinForms.Rules
{
    internal class ExternalInteractorTemplateItemContext : ListItemContext
    {
        private readonly IThreatModel _model;

        public ExternalInteractorTemplateItemContext(IThreatModel model, Scope scope) : 
            base(model?.EntityTemplates?.Where(x => x.EntityType == EntityType.ExternalInteractor).Select(x => x.Name).OrderBy(x => x), scope)
        {
            _model = model;
        }

        public override SelectionRuleNode CreateNode([NotNull] Node node, params object[] parameters)
        {
            SelectionRuleNode result = null;

            if (parameters != null && parameters.Length == 1 && parameters[0] is string entityTemplateName)
            {
                var entityTemplate = _model?.EntityTemplates?.Where(x => x.EntityType == EntityType.ExternalInteractor)
                    .FirstOrDefault(x => string.CompareOrdinal(x.Name, entityTemplateName) == 0);

                if (entityTemplate != null)
                {
                    result = new ExternalInteractorTemplateRuleNode(entityTemplate) {Scope = Scope};
                }
            }

            return result;
        }
    }
}