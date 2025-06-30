using System.Diagnostics;
using Leitor_de_XML.Services;
using Leitor_de_XML.Utils;

namespace Leitor_de_XML {
    public partial class Leitor : Form {
        public Leitor() {
            InitializeComponent();
        }

        private void buscarXmlBtn_Click(object sender, EventArgs e) {
            try {
                var xmlPaths = DialogUtils.BuscarArquivos(filtros: [DialogUtils.FiltroArquivo.XML]);
                var campos = DocService.ExtrairCamposXml(xmlPaths,
                    camposXml: [
                        ("", "CFOP"),
                        ("ICMS", "CST"),
                        ("ICMS", "orig"),
                        ("IPI", "CST"),
                        ("PIS", "CST"),
                        ("COFINS", "CST")
                    ]);

                CriarGrid(campos);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Erro ao ler ou processar XML", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Debug.WriteLine("Exception XML" + ex);
            }
        }

        private void CriarGrid(HashSet<(string colunas, string itens)> campos) {

            var colunas = campos.Select(c => c.colunas).Distinct().ToList();

            foreach (var coluna in colunas) {
                docGrid.Columns.Add(
                    coluna.ToUpper(),
                    char.ToUpperInvariant(coluna[0]) + coluna.Substring(1).ToLower()
                );
            }

            campos = campos.OrderBy(c => c.itens).ToHashSet();
            var maxLinhas = campos.GroupBy(c => c.colunas).Select(c => c.Count()).Max();

            for (var i = 0; i < maxLinhas; i++) {
                var row = docGrid.Rows.Add();
                foreach (var coluna in colunas) {

                    var valor = campos
                        .Where(c => c.colunas == coluna)
                        .Select(c => c.itens)
                        .Skip(i)
                        .FirstOrDefault();

                    docGrid.Rows[i].Cells[coluna.ToUpper()].Value = valor;
                }
            }
        }
    }
}
