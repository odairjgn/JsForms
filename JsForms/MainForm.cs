using Jint;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btExec_Click(object sender, EventArgs e)
        {
            ExecutarScript();
        }

        private void ExecutarScript()
        {
            var engine = new Engine();

            RegistrarMetodos(engine);

            try
            {
                engine.Evaluate(txtJs.Text);
                var form = engine.Invoke("getForm").ToObject() as Form;
                form.ShowDialog();                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegistrarMetodos(Engine engine)
        {
            engine.SetValue("criarForm", () => new Form());
            engine.SetValue("criarBotao", () => new Button());
            engine.SetValue("xy", (int x, int y) => new Point(x, y));
            engine.SetValue("eventoClick", (Control c, EventHandler e) => c.Click += e);
            engine.SetValue("msg", (string msg) => MessageBox.Show(msg));
        }
    }
}
