using System.Text;

namespace Leitor_de_XML.Utils
{
    public static class DialogUtils
    {

        public enum FiltroArquivo
        {
            XML, JSON, ALL
        }

        public static string[] BuscarArquivos(IEnumerable<FiltroArquivo> filtros)
        {
            StringBuilder filtro = new();

            foreach (FiltroArquivo filtroArquivo in filtros)
            {
                filtro.Append(ObterFiltro(filtroArquivo) + '|');
            }

            using OpenFileDialog dialog = new()
            {
                Multiselect = true,
                Filter = filtro.ToString().TrimEnd('|'),
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                RestoreDirectory = true
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.FileNames;
            }

            return [];
        }

        private static string ObterFiltro(FiltroArquivo filtro)
        {
            return filtro switch
            {
                FiltroArquivo.XML => "Arquivos XML (*.xml) | *.xml",
                FiltroArquivo.JSON => "Arquivos JSON (*.json) | *.json",
                FiltroArquivo.ALL => "Todos os arquivos (*.*) | *.*",
                _ => throw new ArgumentException("Filtro inexistente: " + filtro.ToString()),
            };
        }
    }
}
