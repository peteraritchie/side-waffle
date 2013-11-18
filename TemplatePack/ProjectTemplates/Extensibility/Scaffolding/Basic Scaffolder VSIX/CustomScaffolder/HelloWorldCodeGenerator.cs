using Microsoft.AspNet.Scaffolding;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using $safeprojectname$.UI;

namespace $safeprojectname$ {
    public class $safeprojectname$CodeGenerator : CodeGenerator {
        protected string Name { get; set; }
        
        public $safeprojectname$CodeGenerator(CodeGenerationContext context, CodeGeneratorInformation information)
            : base(context, information) {
        }
        public override void GenerateCode() {
            ICodeGeneratorFilesLocator filesLocator = ServiceProvider.GetService(typeof(ICodeGeneratorFilesLocator)) as ICodeGeneratorFilesLocator;
            string filePath = filesLocator.GetStaticFilePath("template.txt", TemplateFolders);

            AddFile(Context.ActiveProject, "foo.txt", filePath, false);

            AddFileFromTemplate(
                project: Context.ActiveProject,
                outputPath: "hello",
                templateName: "hello",
                templateParameters: new Dictionary<string, object>() 
                {
                    {"Name", Name},
                    {"Namespace", Context.ActiveProject.GetDefaultNamespace()},
                },
                skipIfExists: true);
        }

        public override bool ShowUIAndValidate() {
            MessageBox.Show("Scaffolder being invoked");
            InputForm inputForm = new InputForm();

            if (inputForm.ShowDialog()==true) {
                this.Name = inputForm.GetTextValue();

                return true;
            }
            else {
                return false;
            }
        }
    }
}
