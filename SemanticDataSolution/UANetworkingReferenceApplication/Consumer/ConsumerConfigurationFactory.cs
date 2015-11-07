﻿
using System;
using UAOOI.SemanticData.UANetworking.Configuration;

namespace UAOOI.SemanticData.UANetworking.ReferenceApplication.Consumer
{
  /// <summary>
  /// Class ConsumerConfigurationFactory - provides implementation of the <see cref="ConfigurationFactoryBase"/> for the UA Data consumer.
  /// </summary>
  /// <remarks>In production environment it shall be replaced by reading a configuration file.</remarks>
  internal class ConsumerConfigurationFactory : ConfigurationFactoryBase
  {

    /// <summary>
    /// Initializes a new instance of the <see cref="ConsumerConfigurationFactory"/> class.
    /// </summary>
    public ConsumerConfigurationFactory()
    {
      Loader = Configuration.LoadConsumer;
    }

    #region ConfigurationFactoryBase
    /// <summary>
    /// Occurs after the association configuration has been changed.
    /// </summary>
    public override event EventHandler<EventArgs> OnAssociationConfigurationChange;
    /// <summary>
    /// Occurs after the communication configuration has been changed.
    /// </summary>
    public override event EventHandler<EventArgs> OnMessageHandlerConfigurationChange;
    #endregion

  }
}
