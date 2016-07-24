using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SprintWebCS.Models;

namespace SprintWebCS
{
    public partial class ConsultarMateria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                carregarGrid();
            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            carregarGrid();
        }

        private void carregarGrid()
        {
            using (cursomvcEntities context = new cursomvcEntities())
            {
                var dados = (from l in context.materia
                             where ((l.MateriaNome.Contains(txtNome.Text.Trim()) || txtNome.Text.Trim().Equals(""))
                            )
                             select new
                             {
                                 l.MateriaID,
                                 l.MateriaNome
                             }).ToList();
                gridViewConsultar.DataSource = dados;
                gridViewConsultar.DataBind();
            }
        }

        protected void gridViewConsultar_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = int.Parse(e.Values[0].ToString());

            using (cursomvcEntities context = new cursomvcEntities())
            {
                materia materia = context.materia.Where(c => c.MateriaID == id).First();
                context.materia.Remove(materia);
                context.SaveChanges();
            }

            carregarGrid();
        }

        protected void gridViewConsultar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = gridViewConsultar.SelectedRow.Cells[2].Text;
            Response.Redirect("CadastrarMateria.aspx?opcao=Alterar&id=" + id);
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastrarMateria.aspx?opcao=Novo");
        }
    }
}