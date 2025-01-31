﻿using MvvmValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerFIct.Core.Common
{
    public static class ValidationResultExtension
    {
        public static ObservableDictionary<string, string> AsObservableDictionary(this ValidationResult result)
        {
            var dictionary = new ObservableDictionary<string, string>();
            foreach (var item in result.ErrorList)
            {
                var key = item.Target.ToString();
                var text = item.ErrorText;
                if (dictionary.ContainsKey(key))
                {
                    dictionary[key] = dictionary.Keys + Environment.NewLine + text;
                }
                else
                {
                    dictionary[key] = text;
                }
            }
            return dictionary;
        }
    }
}
