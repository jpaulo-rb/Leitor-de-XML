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

            var ultimaTag = string.Empty;

            try {
                while (reader.Read()) {

                    if (reader.NodeType != XmlNodeType.Element) continue;
                    ultimaTag = reader.Name;

                    if (camposComPai.TryGetValue(reader.LocalName, out var camposFilhos)) {
                        using var subtree = reader.ReadSubtree();
                        var tagPai = reader.LocalName;
                        var valores = string.Empty;

                        while (subtree.Read()) {
                            if (subtree.NodeType != XmlNodeType.Element) continue;

                            /*
                            if (camposFilhos.Contains(subtree.LocalName)) {
                                camposXml.Add(($"{tagPai}-{subtree.Name}", subtree.ReadString()));
                            }
                        }
                            */

                            if (camposFilhos.Contains(subtree.LocalName)) {
                                valores = valores + " " + subtree.ReadString();
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
            } catch (XmlException ex) {
                throw new XmlException($"- Tag malformada: <{ultimaTag}>", ex);
            }

            return camposXml;
        }
    }
}