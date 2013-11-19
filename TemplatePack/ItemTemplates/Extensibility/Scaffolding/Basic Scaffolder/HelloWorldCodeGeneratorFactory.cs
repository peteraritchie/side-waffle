using $rootnamespace$.Properties;
using Microsoft.AspNet.Scaffolding;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $rootnamespace$ {
    [Export(typeof(CodeGeneratorFactory))]
    public class $safeitemname$ : CodeGeneratorFactory {
        public $safeitemname$()
            :base(CreateCodeGeneratorInformation()){
    }
        public override ICodeGenerator CreateInstance(CodeGenerationContext context) {
            
            return new MyCodeGenerator(context,CreateCodeGeneratorInformation());
        }

        private static CodeGeneratorInformation CreateCodeGeneratorInformation()
        {
            return new CodeGeneratorInformation(
                displayName: "My Scaffolder",
                description: "My Scaffolder Description",
                author: "Your Name Here",
                version: new Version(1, 0, 0, 0),
                id: typeof(MyCodeGenerator).Name,
                gestures: new[] { (string)null },
                icon: Resources.codegenicon.ToBitmap().ToImageSource(),
                categories: new[] { "$safeitemname$" }
                );
        }
    }
}
