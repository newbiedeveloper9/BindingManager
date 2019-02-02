using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingManager
{
    public partial class Form1 : Form
    {
        public static readonly string TemplatesPath = "Templates";
        public static readonly string TemplateExtension = "templ";

        public Form1()
        {
            InitializeComponent();

            Directory.CreateDirectory(TemplatesPath);
            Task.Factory.StartNew(RefreshTemplateTypes);
        }

        private void generateCode_Click(object sender, EventArgs e)
        {
            codeTxtBox.ResetText();
            foreach (var line in bindingTxtBox.Lines)
            {
                if (string.IsNullOrEmpty(line))
                    continue;

                string varName;
                string varType;

                if (line.Contains(" "))
                {
                    var separatedLine = line.Split(' ');
                    varName = separatedLine[0];
                    varType = separatedLine[1];
                }
                else
                {
                    varName = line;
                    varType = "default";
                }

                var template = GetTemplateOrDefault(varType);
                var code = GenerateCodeByTemplate(template, varName, varType);
                codeTxtBox.AppendText(code);
                codeTxtBox.Text += Environment.NewLine + Environment.NewLine;
            }
        }

        private string GenerateCodeByTemplate(string templ, string varName, string varType)
        {
            var fieldName = GetNameAsField(varName);

            templ = templ.Replace("__field__", fieldName);
            templ = templ.Replace("__prop__", varName);
            templ = templ.Replace("__type__", varType);

            return templ;
        }

        private string GetTemplateOrDefault(string varType) =>
             File.Exists(GetTemplatePath(varType)) ? File.ReadAllText(GetTemplatePath(varType)) : File.ReadAllText(GetTemplatePath("default"));

        private string GetTemplatePath(string templateName) =>
            $@"{Path.GetDirectoryName(Application.ExecutablePath)}\{TemplatesPath}\{templateName}.{TemplateExtension}";

        private string GetNameAsField(string varName)
        {
            var toLower = varName.ToLower();
            var afterRemove = varName.Remove(0, 1);
            return $"_{toLower[0]}{afterRemove}";
        }

        private string[] GetTemplateTypes()
        {
            var files = Directory.GetFiles($@"{Path.GetDirectoryName(Application.ExecutablePath)}\{TemplatesPath}\",
                 $"*.{TemplateExtension}");

            for (var i = 0; i < files.Length; i++)
                files[i] = Path.GetFileNameWithoutExtension(files[i]);

            return files;
        }

        private void RefreshTemplateTypes()
        {
            while (true)
            {
                ThreadHelperClass.SetText(this, templTypesTxtBox, GetTemplateTypes());
                Thread.Sleep(1500);
            }
        }
    }
}
