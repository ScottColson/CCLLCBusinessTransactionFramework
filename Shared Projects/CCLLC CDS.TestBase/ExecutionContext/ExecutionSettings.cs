using System;
using System.Collections.Generic;
using CCLLC.Core;

namespace CCLLC.CDS.Test.ExecutionContext
{
    public class FakeExecutionSettings : ISettingsProvider
    {
        char[] SEPARATORS = { ';', ',' };

        private IDictionary<string, string> Settings;

        public FakeExecutionSettings()
            :this(new Dictionary<string, string>())
        { }

        public FakeExecutionSettings(IDictionary<string,string> settings)
        {
            Settings = settings ?? throw new ArgumentNullException("settings");
        }

        public T Get<T>(string Key, T DefaultValue = default(T))
        {
            string value;           

            if (Settings.TryGetValue(Key.ToLower(), out value))
            {
                if (typeof(T) != typeof(string[]))
                    return (T)((object)Convert.ChangeType(value, typeof(T)));
                else
                {
                    //create a string array to return
                    string[] strArray = new string[0];
                    string stringValue = value.ToString();

                    if (!string.IsNullOrEmpty(stringValue))
                    {
                        //remove any white space following the seperator.
                        value = System.Text.RegularExpressions.Regex.Replace(value, @";\s+", ";");

                        //split the exlusion field string into an array
                        strArray = value.Split(SEPARATORS, StringSplitOptions.RemoveEmptyEntries);
                    }

                    return (T)((object)strArray);
                }
            }
            else
                return DefaultValue;

        }
    }
}
