
using NetMQ.Monitoring;

namespace NetMQ
{
    /// <summary>
    ///
    /// </summary>
    /// <remarks>
    /// This interface provides an abstraction over the legacy Poller and newer <see cref="NetMQPoller"/> classes for use in <see cref="NetMQMonitor"/>.
    /// </remarks>
    public interface ISocketPollableCollection
    {
        /// <summary>
        /// </summary>
        void Add( ISocketPollable socket);
        /// <summary>
        /// </summary>
        void Remove( ISocketPollable socket);
    }
}