//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("App2.BehavioursPage.xaml", "BehavioursPage.xaml", typeof(global::App2.BehavioursPage))]

namespace App2 {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("BehavioursPage.xaml")]
    public partial class BehavioursPage : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Entry entryEmail;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::App2.Behaviours.EmailBehaviour EmailBehaviours;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(BehavioursPage));
            entryEmail = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Entry>(this, "entryEmail");
            EmailBehaviours = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::App2.Behaviours.EmailBehaviour>(this, "EmailBehaviours");
        }
    }
}
