using Microsoft.AspNet.Scaffolding;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace $safeprojectname$ {
    public class $safeprojectname$CodeGenerator : CodeGenerator {
        public $safeprojectname$CodeGenerator(CodeGenerationContext context, CodeGeneratorInformation information)
            : base(context, information) {
        }
        public override void GenerateCode() {
            ICodeGeneratorFilesLocator filesLocator = ServiceProvider.GetService(typeof(ICodeGeneratorFilesLocator)) as ICodeGeneratorFilesLocator;
            string filePath = filesLocator.GetStaticFilePath("template.txt", TemplateFolders);

            AddFile(Context.ActiveProject, "foo.txt", filePath, false);
        }

        public override bool ShowUIAndValidate() {
            MessageBox.Show("Scaffolder being invoked");
            return true;
        }
    }
}
