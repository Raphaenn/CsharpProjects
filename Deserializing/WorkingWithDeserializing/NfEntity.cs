using System;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace NfeEntity
{
    [XmlRoot("NFe", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public class NFe
    {
        public infNFe infNFe { get; set; }
    }

    public class infNFe
    {
        public ide ide { get; set; }
        public dest dest { get; set; }
        public Det det { get; set; }
    }

    public class ide
    {
        public string cUF { get; set; }
        public string cNF { get; set; }
        public string natOp { get; set; }
        public string indPag { get; set; }
        public string mod { get; set; }
        public string serie { get; set; }
        public string nNF { get; set; }
        public DateTime dEmi { get; set; }
        public DateTime dSaiEnt { get; set; }
        public string tpNF { get; set; }
        public string cMunFG { get; set; }
        public string tpImp { get; set; }
        public string tpEmis { get; set; }
        public string cDV { get; set; }
        public string tpAmb { get; set; }
        public string finNFe { get; set; }
        public string procEmi { get; set; }
        public string verProc { get; set; }
    }

    public class dest
    {
        public string CNPJ { get; set; }
        public string xNome { get; set; }
        public enderDest enderDest { get; set; }
        public string IE { get; set; }
    }

    public class enderDest
    {
        public string xLgr { get; set; }
        public string nro { get; set; }
        public string xCpl { get; set; }
        public string xBairro { get; set; }
        public string cMun { get; set; }
        public string xMun { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
        public string cPais { get; set; }
        public string xPais { get; set; }
        public string fone { get; set; }
    }

    public class Prod
    {
        public string xProd { get; set; }
    }

    public class Det
    {
        public Prod prod { get; set; }
    }

}

