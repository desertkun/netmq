/*
    Copyright (c) 2011 250bpm s.r.o.
    Copyright (c) 2011-2015 Other contributors as noted in the AUTHORS file

    This file is part of 0MQ.

    0MQ is free software; you can redistribute it and/or modify it under
    the terms of the GNU Lesser General Public License as published by
    the Free Software Foundation; either version 3 of the License, or
    (at your option) any later version.

    0MQ is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Lesser General Public License for more details.

    You should have received a copy of the GNU Lesser General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/


using NetMQ.Core.Transports.Tcp;
using AsyncIO;
using System.Net.Sockets;

namespace NetMQ.Core.Transports.Ipc
{
    /// <summary>
    /// An IpcListener is a TcpListener that also has an Address property and a SetAddress method.
    /// </summary>
    internal sealed class IpcListener : NetMQ.Core.Transports.Tcp.TcpListener
    {
        /// <summary>
        /// Create a new IpcListener with the given IOThread, socket, and Options.
        /// </summary>
        /// <param name="ioThread"></param>
        /// <param name="socket">the SocketBase to listen to</param>
        /// <param name="options">an Options value that dictates the settings for this IpcListener</param>
        public IpcListener( IOThread ioThread,  SocketBase socket,  Options options)
            : base(ioThread, socket, options)
        {
        }

        protected override Address.IZAddress NewAddress()
        {
            return new IpcAddress();
        }

        protected override AsyncSocket NewSocket()
        {
            return AsyncSocket.Create(AddressFamily.Unix, SocketType.Stream, ProtocolType.IP);
        }
    }
}
