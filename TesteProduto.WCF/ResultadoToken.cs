using System.Runtime.Serialization;

namespace TesteProduto.WCF
{
    [DataContract]
    public class ResultadoToken
    {
        [DataMember]
        public double Peso { get; set; }

        [DataMember]
        public double Altura { get; set; }

        [DataMember]
        public double ValorIMC { get; set; }

        [DataMember]
        public string DescSituacao { get; set; }
    }
}