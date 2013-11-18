using Microsoft.AspNet.Scaffolding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$ {
    public class $safeprojectname$CodeGenerator : CodeGenerator {
        public $safeprojectname$CodeGenerator(CodeGenerationContext context, CodeGeneratorInformation information)
            : base(context, information) {
        }
        public override void GenerateCode() {
            AddFile(Context.ActiveProject, "foo.txt", @"C:\Data\Files\template.txt", false);
        }

        public override bool ShowUIAndValidate() {
            MessageBox.Show("Scaffolder being invoked");
            return true;
        }
    }
}
