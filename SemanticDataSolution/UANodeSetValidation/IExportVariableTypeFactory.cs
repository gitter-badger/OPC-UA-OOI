﻿
namespace UAOOI.SemanticData.UANodeSetValidation
{
  public interface IExportVariableTypeFactory : IExportTypeFactory
  {
    System.Xml.XmlElement DefaultValue
    {
      set;
    }

    System.Xml.XmlQualifiedName DataType
    {
      set;
    }
    int ValueRank
    {
      set;
    }
    bool ValueRankSpecified
    {
      set;
    }
    string ArrayDimensions
    {
      set;
    }

  }
}
