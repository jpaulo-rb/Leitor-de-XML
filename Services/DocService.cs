using Leitor_de_XML.Infrastructure;
using System.Xml;

namespace Leitor_de_XML.Services
{
    public static class DocService
    {

        public static HashSet<(string tag, string valor)> ExtrairCamposXml(string[] xmlPaths, HashSet<(string, string)> camposXml)
        {

            HashSet<(string, string)> itens = [];

            foreach (var xmlPath in xmlPaths)
            {
                using Stream stream = File.OpenRead(xmlPath);
                try
                {
                    var campos = DocReader.RecuperarCamposXml(stream, camposXml);
                    itens.UnionWith(campos);
                }
                catch (XmlException ex)
                {
                    throw new XmlException($"- Erro ao ler o arquivo: {xmlPath}\n{ex.Message}", ex);
                }
            }

            return itens;
        }
    }
}

/*
var sw1 = Stopwatch.StartNew();
var locker = new object();
HashSet<(string, string)> itens2 = [];

Parallel.ForEach(
    xmlPaths,
    new ParallelOptions { MaxDegreeOfParallelism = 2 },
    () => new HashSet<(string, string)>(), // Inicializa um HashSet local por thread
    (xmlPath, state, localSet) => {
        using Stream stream = File.OpenRead(xmlPath);
        var dados = DocReader.RecuperarCamposXml(stream, camposXml);
        localSet.UnionWith(dados); // Acumula localmente (sem lock)
        return localSet;
    },
    (localSet) => {
        lock (locker) // Combina os resultados ao final (lock breve)
        {
            itens.UnionWith(localSet);
        }
    }
);
sw1.Stop();

MessageBox.Show($"Parallel: {sw1.ElapsedMilliseconds}\nForeach: {sw2.ElapsedMilliseconds}");
*/
