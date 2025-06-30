using System.Xml;

namespace Leitor_de_XML.Infrastructure {
    public static class DocReader {

        public static HashSet<(string Tag, string Valor)> RecuperarCamposXml
            (Stream stream, HashSet<(string TagPai, string TagFilho)> campos) {

            using var reader = XmlReader.Create(stream);
            HashSet<(string, string)> camposXml = [];

            HashSet<string> camposSemPai = campos
                .Where(c => c.TagPai == "")
                .Select(c => c.TagFilho)
                .ToHashSet();

            Dictionary<string, HashSet<string>> camposComPai = campos
                .Where(c => c.TagPai != "")
                .GroupBy(c => c.TagPai)
                .ToDictionary(
                    g => g.Key,
                    g => g.Select(c => c.TagFilho).ToHashSet()
                );

            while (reader.Read()) {
                if (reader.NodeType != XmlNodeType.Element) continue;

                if (camposComPai.TryGetValue(reader.LocalName, out var camposFilhos)) {
                    using var subtree = reader.ReadSubtree();
                    var tagPai = reader.LocalName;
                    var valores = string.Empty;

                    while (subtree.Read()) {
                        if (subtree.NodeType != XmlNodeType.Element) continue;

                        if (camposFilhos.Contains(subtree.LocalName)) {
                            valores += reader.ReadString();
                            continue;
                        }
                    }

                    camposXml.Add(($"{tagPai}", valores));
                }

                if (camposSemPai.Contains(reader.Name)) {
                    camposXml.Add(
                        ($"{reader.Name}", reader.ReadString()));
                    continue;
                }
            }



            return camposXml;
        }
    }
}