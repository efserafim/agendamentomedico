using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using AgendamentoMedico.Dados;

namespace AgendamentoMedico
{
    internal static class Program
    {
        /// <summary>
        /// O ponto de entrada principal para a aplicação.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Inicializar banco de dados
            using (var contexto = new ContextoClinica())
            {
                contexto.Database.EnsureCreated();
            }
            
            Application.Run(new FormularioPrincipal());
        }
    }
}