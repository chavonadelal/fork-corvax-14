using System;
using Content.Shared.Ghost.Roles;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.CustomControls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client.Ghost.Roles.UI
{
    [GenerateTypedNameReferences]
    public partial class GhostRoleRulesWindow : SS14Window
    {
        public GhostRoleRulesWindow(string rules, Action<BaseButton.ButtonEventArgs> requestAction)
        {
            RobustXamlLoader.Load(this);
            Title.SetMessage(rules);
            RequestButton.OnPressed += requestAction;
        }
    }
}