﻿using Cake.Core.IO;

namespace Cake.Terraform
{
    using System.Collections.Generic;

    public class TerraformPlanSettings : TerraformSettings
    {
        public FilePath OutFile { get; set; }

        public int Parallelism { get; set; }

        /// <summary>
        ///     Gets or sets the input variables. https://www.terraform.io/intro/getting-started/variables.html
        /// </summary>
        public Dictionary<string, string> InputVariables { get; set; }

        public bool Destroy { get; set; }
    }
}