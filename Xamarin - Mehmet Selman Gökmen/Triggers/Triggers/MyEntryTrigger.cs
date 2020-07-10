using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace UdemyCourse.Triggers
{
    public class MyEntryTrigger : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            if (string.Equals(sender.Placeholder, "Dene"))
                sender.Text = RemoveDigits(sender.Text);
        }

        public static string RemoveDigits(string key)
        {
            return Regex.Replace(key, @"\d", "");
        }
    }
}
