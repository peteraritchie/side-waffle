using Microsoft.AspNet.Scaffolding;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$ {
    [Export(typeof(CodeGeneratorFactory))]
    public class $safeprojectname$CodeGeneratorFactory : CodeGeneratorFactory {
        public $safeprojectname$CodeGeneratorFactory()
            :base(CreateCodeGeneratorInformation()){
    }
        public override ICodeGenerator CreateInstance(CodeGenerationContext context) {
            return new $safeprojectname$CodeGenerator(context,CreateCodeGeneratorInformation());
        }

        private static CodeGeneratorInformation CreateCodeGeneratorInformation()
        {
            return new CodeGeneratorInformation(
                displayName: "$safeprojectname$ Scaffolder",
                description: "$safeprojectname$Scaffolder Scaffolder Description",
                author: "Your Name Here",
                version: new Version(1, 0, 0, 0),
                id: typeof($safeprojectname$CodeGenerator).Name,
                gestures: new[] { (string)null },
                icon: null,
                categories: new[] { "$safeprojectname$" }
                );
        }
    }
}
