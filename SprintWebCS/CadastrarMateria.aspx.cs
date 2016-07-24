using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SprintWebCS.Models;

namespace SprintWebCS
{
    public partial class CadastrarMateria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["opcao"] != null && Request.QueryString["opcao"].ToString().Equals("Alterar"))
                {
                    carregarForm(int.Parse(Request.QueryString["id"].ToString()));
                }
            }

        }

        private void carregarForm(int id)
        {
            materia materia;
            using (cursomvcEntities context = new cursomvcEntities())
            {
                materia = (from c in context.materia
                           where (c.MateriaID == id)
                           select c).First();
            }
            txtDesc.Text = materia.MateriaNome.Trim();
            txtID.Text = materia.MateriaID.ToString().Trim();
        }


        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            materia materia;
            using (cursomvcEntities context = new cursomvcEntities())
            {
                //Cadastro Novo
                if (Request.QueryString["opcao"] != null && Request.QueryString["opcao"].ToString().Equals("Novo"))
                {
                    materia = new materia();
                }
                else
                {
                    int id = int.Parse(txtID.Text.Trim());
                    materia = (from c in context.materia
                               where (c.MateriaID == id)
                               select c).First();
                }
                materia.MateriaNome = txtDesc.Text.Trim();

                if (Request.QueryString["opcao"].ToString().Equals("Novo"))
                {
                    context.materia.Add(materia);
                }
                context.SaveChanges();
                Response.Redirect("ConsultarMateria.aspx?");
            }
        }
    }
}