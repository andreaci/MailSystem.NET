// Copyright 2001-2010 - Active Up SPRLU (http://www.agilecomponents.com)
//
// This file is part of MailSystem.NET.
// MailSystem.NET is free software; you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
// 
// MailSystem.NET is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.

// You should have received a copy of the GNU Lesser General Public License
// along with SharpMap; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA 

namespace ActiveUp.Net.Mail
{
    /*/// <summary>
    /// EventHandler to be used with the Progress event.
    /// </summary>
    public delegate void ProgressEventHandler(object sender, ActiveUp.Net.Mail.ProgressEventArgs e);*/
    /// <summary>
    /// EventHandler to be used with the Authenticating event.
    /// </summary>
    public delegate void AuthenticatingEventHandler(object sender, AuthenticatingEventArgsBase e);
    /// <summary>
    /// EventHandler to be used with the Authenticated event.
    /// </summary>
    public delegate void AuthenticatedEventHandler(object sender, AuthenticatedEventArgsBase e);
    /// <summary>
    /// EventHandler to be used with the Nooping event.
    /// </summary>
    public delegate void NoopingEventHandler(object sender);
    /// <summary>
    /// EventHandler to be used with the Nooped event.
    /// </summary>
    public delegate void NoopedEventHandler(object sender);
    /// <summary>
    /// EventHandler to be used with the TcpWriting event.
    /// </summary>
    public delegate void TcpWritingEventHandler(object sender, TcpWritingEventArgs e);
    /// <summary>
    /// EventHandler to be used with the TcpWritten event.
    /// </summary>
    public delegate void TcpWrittenEventHandler(object sender, TcpWrittenEventArgs e);
    /// <summary>
    /// EventHandler to be used with the TcpReading event.
    /// </summary>
    public delegate void TcpReadingEventHandler(object sender);
    /// <summary>
    /// EventHandler to be used with the TcpRead event.
    /// </summary>
    public delegate void TcpReadEventHandler(object sender, TcpReadEventArgs e);
    /// <summary>
    /// EventHandler to be used with the MessageRetrieving event.
    /// </summary>
    public delegate void MessageRetrievingEventHandler(object sender, MessageRetrievingEventArgs e);
    /// <summary>
    /// EventHandler to be used with the MessageRetrieved event.
    /// </summary>
    public delegate void MessageRetrievedEventHandler(object sender, MessageRetrievedEventArgs e);
    /*/// <summary>
    /// EventHandler to be used with the BodyRetrieving event.
    /// </summary>
    public delegate void BodyRetrievingEventHandler(object sender, ActiveUp.Net.Mail.BodyRetrievingEventArgs e);
    /// <summary>
    /// EventHandler to be used with the BodyRetrieved event.
    /// </summary>
    public delegate void BodyRetrievedEventHandler(object sender, ActiveUp.Net.Mail.BodyRetrievedEventArgs e);
    /// <summary>
    /// EventHandler to be used with the ArticleRetrieving event.
    /// </summary>
    public delegate void ArticleRetrievingEventHandler(object sender, ActiveUp.Net.Mail.ArticleRetrievingEventArgs e);
    /// <summary>
    /// EventHandler to be used with the ArticleRetrieved event.
    /// </summary>
    public delegate void ArticleRetrievedEventHandler(object sender, ActiveUp.Net.Mail.ArticleRetrievedEventArgs e);*/
    /// <summary>
    /// EventHandler to be used with the HeaderRetrieving event.
    /// </summary>
    public delegate void HeaderRetrievingEventHandler(object sender, HeaderRetrievingEventArgs e);
    /// <summary>
    /// EventHandler to be used with the HeaderRetrieved event.
    /// </summary>
    public delegate void HeaderRetrievedEventHandler(object sender, HeaderRetrievedEventArgs e);
    /// <summary>
    /// EventHandler to be used with the Disconnecting event.
    /// </summary>
    public delegate void DisconnectingEventHandler(object sender);
    /// <summary>
    /// EventHandler to be used with the Disconnected event.
    /// </summary>
    public delegate void DisconnectedEventHandler(object sender, DisconnectedEventArgs e);
    /// <summary>
    /// EventHandler to be used with the Connecting event.
    /// </summary>
    public delegate void ConnectingEventHandler(object sender);
    /// <summary>
    /// EventHandler to be used with the Connected event.
    /// </summary>
    public delegate void ConnectedEventHandler(object sender, ConnectedEventArgs e);
    /// <summary>
    /// EventHandler to be used with the MessageSending event.
    /// </summary>
    public delegate void MessageSendingEventHandler(object sender, MessageSendingEventArgs e);
    /// <summary>
    /// EventHandler to be used with the MessageSent event.
    /// </summary>
    public delegate void MessageSentEventHandler(object sender, MessageSentEventArgs e);
    /// <summary>
    /// EventHandler to be used with the NewMessage event.
    /// </summary>
    public delegate void NewMessageReceivedEventHandler(object sender, NewMessageReceivedEventArgs e);

    /// <summary>
    /// EventArgs used by the Disconnected event.
    /// </summary>
#if !PocketPC
    [System.Serializable]
#endif
    public class DisconnectedEventArgs : System.EventArgs
    {
        private string serverresponse;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="serverresponse">The remote server's response.</param>
        public DisconnectedEventArgs(string serverresponse)
        {
            this.serverresponse = serverresponse;
        }
        /// <summary>
        /// The remote server's response.
        /// </summary>
        public string ServerResponse
        {
            get
            {
                return serverresponse;
            }
        }
    }

    /// <summary>
    /// EventArgs used by the Connected event.
    /// </summary>
#if !PocketPC
    [System.Serializable]
#endif
    public class ConnectedEventArgs : System.EventArgs
    {
        private string serverresponse;
        //private bool connected;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="serverresponse">The remote server's response.</param>
        public ConnectedEventArgs(string serverresponse)
        {
            this.serverresponse = serverresponse;
        }
        /// <summary>
        /// The remote server's response.
        /// </summary>
        public string ServerResponse
        {
            get
            {
                return serverresponse;
            }
        }
    }

    /// <summary>
    /// EventArgs used by the MessageRetrieved event.
    /// </summary>
#if !PocketPC
    [System.Serializable]
#endif
    public class MessageRetrievedEventArgs : System.EventArgs
    {
        byte[] _data;
        int _index;
        int _totalCount;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="data">The retrieved message as a byte array.</param>
        /// <param name="index">The index of the message that has been retrieved.</param>
        /// <param name="totalCount">The total amount of messages on the remote server (POP3 only).</param>
        public MessageRetrievedEventArgs(byte[] data, int index, int totalCount)
        {
            _data = data;
            _index = index;
            _totalCount = totalCount;
        }
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="data">The retrieved message as a byte array.</param>
        /// <param name="index">The index of the message that has been retrieved.</param>
        public MessageRetrievedEventArgs(byte[] data, int index)
        {
            _data = data;
            _index = index;
            _totalCount = -1;
        }
        /// <summary>
        /// The retrieved message as a Message object.
        /// </summary>
        public Message Message
        {
            get
            {
                return Parser.ParseMessage(_data);
            }
        }
        /// <summary>
        /// The retrieved message's index on the remote server.
        /// </summary>
        public int MessageIndex
        {
            get
            {
                return _index;
            }
        }
        /// <summary>
        /// The total amount of messages on the remote server (POP3 only).
        /// </summary>
        public int TotalCount
        {
            get
            {
                return _totalCount;
            }
        }
    }

    /// <summary>
    /// EventArgs used by the MessageRetrieving event.
    /// </summary>
#if !PocketPC
    [System.Serializable]
#endif
    public class MessageRetrievingEventArgs : System.EventArgs
    {
        int _index;
        int _totalCount;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="index">The message to be retrieved's index.</param>
        /// <param name="totalCount">The total amount of messages on the remote server.</param>
        public MessageRetrievingEventArgs(int index, int totalCount)
        {
            _index = index;
            _totalCount = totalCount;
        }
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="index">The message to be retrieved's index.</param>
        public MessageRetrievingEventArgs(int index)
        {
            _index = index;
            _totalCount = -1;
        }
        /// <summary>
        /// The index of the message to be retrieved on the remote server.
        /// </summary>
        public int MessageIndex
        {
            get
            {
                return _index;
            }
        }
        /// <summary>
        /// The total amount of messages on the remote server (POP3 only).
        /// </summary>
        public int TotalCount
        {
            get
            {
                return _totalCount;
            }
        }
    }

    /*/// <summary>
    /// EventArgs used by the Progress event.
    /// </summary>
    [System.Serializable]
    public class ProgressEventArgs : System.EventArgs
    {
        int _bytesRead;
        int _totalBytes;
        int _totalSize;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="bytesRead">The amount of bytes read from the remote server since the event has been fired.</param>
        /// <param name="totalBytes">The total amount of bytes read from the server during the operation up to now.</param>
        /// <param name="totalSize">The total amount of bytes to be downloaded during the operation.</param>
        public ProgressEventArgs(int bytesRead, int totalBytes, int totalSize)
        {
            this._bytesRead = bytesRead;
            this._totalBytes = totalBytes;
            this._totalSize = totalSize;
        }
        /// <summary>
        /// The amount of bytes read from the remote server since the last event firing.
        /// </summary>
        public int BytesRead
        {
            get
            {
                return this._bytesRead;
            }
        }
        /// <summary>
        /// The total amount of bytes read from the remote server in this operation.
        /// </summary>
        public int TotalBytes
        {
            get
            {
                return this._totalBytes;
            }
        }
        /// <summary>
        /// The total amount of bytes to be read from the remote server in this operation.
        /// </summary>
        public int TotalSize
        {
            get
            {
                return this._totalSize;
            }
        }
    }*/

    /// <summary>
    /// EventArgs used by the HeaderRetrieved event.
    /// </summary>
#if !PocketPC
    [System.Serializable]
#endif
    public class HeaderRetrievedEventArgs : System.EventArgs
    {
        byte[] _data;
        int _index;
        int _totalCount = -1;

        /// <summary>
        /// Event
        /// </summary>
        /// <param name="data">The retrieved Header as a byte array.</param>
        /// <param name="index">The index of the Header retrieved.</param>
        /// <param name="totalCount">The total amount of messages on the remote server (POP3 only).</param>
        public HeaderRetrievedEventArgs(byte[] data, int index, int totalCount)
        {
            _index = index;
            _totalCount = totalCount;
            _data = data;
        }
        /// <summary>
        /// Event
        /// </summary>
        /// <param name="data">The retrieved Header as a byte array.</param>
        /// <param name="index">The index of the retrieved header.</param>
        public HeaderRetrievedEventArgs(byte[] data, int index)
        {
            _index = index;
            _data = data;
            _totalCount = -1;
        }
        /// <summary>
        /// The Header retrieved from the remote server.
        /// </summary>
        public Header Header
        {
            get
            {
                return Parser.ParseHeader(_data);
            }
        }
        /// <summary>
        /// The index of the message Header retrieved on the remote server.
        /// </summary>
        public int MessageIndex
        {
            get
            {
                return _index;
            }
        }
        /// <summary>
        /// The total amount of messages on the remote server (POP3 only).
        /// </summary>
        public int TotalCount
        {
            get
            {
                return _totalCount;
            }
        }
    }

    /// <summary>
    /// EventArgs used by the HeaderRetrieving event.
    /// </summary>
#if !PocketPC
    [System.Serializable]
#endif
    public class HeaderRetrievingEventArgs : System.EventArgs
    {
        int _index;
        int _totalCount = -1;

        /// <summary>
        /// Constructor.
        /// </summary>
        public HeaderRetrievingEventArgs(int index, int totalCount)
        {
            _index = index;
            _totalCount = totalCount;
        }
        /// <summary>
        /// Constructor.
        /// </summary>
        public HeaderRetrievingEventArgs(int index)
        {
            _index = index;
        }
        /// <summary>
        /// The index of the message Header to be retrieved on the remote server.
        /// </summary>
        public int MessageIndex
        {
            get
            {
                return _index;
            }
        }
        /// <summary>
        /// The total amount of messages on the remote server (POP3 only).
        /// </summary>
        public int TotalCount
        {
            get
            {
                return _totalCount;
            }
        }
    }

    /// <summary>
    /// EventArgs used by the TcpWritten event.
    /// </summary>
#if !PocketPC
    [System.Serializable]
#endif
    public class TcpWrittenEventArgs : System.EventArgs
    {
        string _data;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="data">Data sent to the server.</param>
        public TcpWrittenEventArgs(string data)
        {
            _data = data;
        }
        /// <summary>
        /// Data sent to the server.
        /// </summary>
        public string Command
        {
            get
            {
                return _data;
            }
        }
    }

    /// <summary>
    /// EventArgs used by the TcpWriting event.
    /// </summary>
#if !PocketPC
    [System.Serializable]
#endif
    public class TcpWritingEventArgs : System.EventArgs
    {
        string _data;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="data">Data sent to the server.</param>
        public TcpWritingEventArgs(string data)
        {
            _data = data;
        }
        /// <summary>
        /// Data sent to the server.
        /// </summary>
        public string Command
        {
            get
            {
                return _data;
            }
        }
    }

    /// <summary>
    /// EventArgs used by the TcpRead event.
    /// </summary>
#if !PocketPC
    [System.Serializable]
#endif
    public class TcpReadEventArgs : System.EventArgs
    {
        string _data;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="data">Data received from the server.</param>
        public TcpReadEventArgs(string data)
        {
            _data = data;
        }
        /// <summary>
        /// The server's response.
        /// </summary>
        public string Response
        {
            get
            {
                return _data;
            }
        }
    }

    /// <summary>
    /// Represents an authentication process.
    /// </summary>
#if !PocketPC
    [System.Serializable]
#endif
    public class AuthEventArgsBase : System.EventArgs
    {
        public string Message { get; set; }
    }

    public class AuthenticatedEventArgsBase : AuthEventArgsBase
    {

        protected string _username, _password, _host, _serverResponse;
        public string Username
        {
            get
            {
                return _username;
            }
        }

        /// <summary>
        /// The address of the remote server.
        /// </summary>
        public string Host
        {
            get
            {
                return _host;
            }
        }

        /// <summary>
        /// The server's response
        /// </summary>
        public string ServerResponse
        {
            get
            {
                return _serverResponse;
            }
        }
    }

    public class AuthenticatedEventArgs : AuthenticatedEventArgsBase
    {
 
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="username">Username used to authenticate the user.</param>
        /// <param name="password">Password used to authenticate the user.</param>
        /// <param name="host">Address of the remote server.</param>
        /// <param name="serverResponse">The server response to the PASS command.</param>
        public AuthenticatedEventArgs(string username, string password, string host, string serverResponse)
        {
            _username = username;
            _password = password;
            _host = host;
            _serverResponse = serverResponse;
        }
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="username">Username used to authenticate the user.</param>
        /// <param name="password">Password used to authenticate the user.</param>
        /// <param name="serverResponse">The server response to the PASS command.</param>
        public AuthenticatedEventArgs(string username, string password, string serverResponse)
        {
            _username = username;
            _password = password;
            _host = "unknown";
            _serverResponse = serverResponse;
        }
        /// <summary>
        /// The password used to authenticate the user.
        /// </summary>
        public string Password
        {
            get
            {
                return _password;
            }
        }
      
    }

    public class AuthenticatedOAuth2EventArgs : AuthenticatedEventArgsBase
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="username">Username used to authenticate the user.</param>
        /// <param name="host">Address of the remote server.</param>
        /// <param name="serverResponse">The server response to the PASS command.</param>
        public AuthenticatedOAuth2EventArgs(string username,  string host, string serverResponse)
        {
            _username = username;
            _host = host;
            _serverResponse = serverResponse;

            Message = $"AUTHENTICATED: username = {_username}; host = {_host}; serverResponse = {_serverResponse}";
        }
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="username">Username used to authenticate the user.</param>
        /// <param name="serverResponse">The server response to the PASS command.</param>
        public AuthenticatedOAuth2EventArgs(string username, string serverResponse)
        {
            _username = username;
            _host = "unknown";
            _serverResponse = serverResponse;
            Message = $"AUTHENTICATED: username = {_username}; serverResponse = {_serverResponse}";
        }

    }
    /// <summary>
    /// Represents a future authentication process.
    /// </summary>
#if !PocketPC
    [System.Serializable]
#endif



    public class AuthenticatingEventArgsBase : AuthEventArgsBase
    {

        protected string _username, _host;

        /// <summary>
        /// The username used to authenticate the user.
        /// </summary>
        public string Username
        {
            get
            {
                return _username;
            }
        }

        /// <summary>
        /// The address of the remote server.
        /// </summary>
        public string Host
        {
            get
            {
                return _host;
            }
        }
  }

    public class AuthenticatingEventArgs : AuthenticatingEventArgsBase
    {
        string _password;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="username">Username used to authenticate the user.</param>
        /// <param name="password">Password used to authenticate the user.</param>
        /// <param name="host">Address of the remote server.</param>
        public AuthenticatingEventArgs(string username, string password, string host)
        {
            _username = username;
            _password = password;
            _host = host;
        }
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="username">Username used to authenticate the user.</param>
        /// <param name="password">Password used to authenticate the user.</param>
        public AuthenticatingEventArgs(string username, string password)
        {
            _username = username;
            _password = password;
            _host = "unkwown";
        }

        /// <summary>
        /// The password used to authenticate the user.
        /// </summary>
        public string Password
        {
            get
            {
                return _password;
            }
        }
    }

    public class AuthenticatingOAuth2EventArgs : AuthenticatingEventArgsBase
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="username">Username used to authenticate the user.</param>
        /// <param name="token">Password used to authenticate the user.</param>
        /// <param name="host">Address of the remote server.</param>
        public AuthenticatingOAuth2EventArgs(string username, string host)
        {
            _username = username;
            _host = host;
            Message = $"AUTHENTICATING: username = {username}; host = {_host}";
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="username">Username used to authenticate the user.</param>
        /// <param name="token">Password used to authenticate the user.</param>
        public AuthenticatingOAuth2EventArgs(string username)
        {
            _username = username;
            _host = "unkwown";
            Message = $"AUTHENTICATING: username = {username}";
        }
    }

    /*/// <summary>
    /// EventArgs used by the ArticleRetrieved event.
    /// </summary>
    [System.Serializable]
    public class ArticleRetrievedEventArgs : System.EventArgs
    {
        ActiveUp.Net.Mail.Message _message;
        int _index;
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="data">The retrieved article as a byte array.</param>
        /// <param name="index">The index of the article that has been retrieved.</param>
        public ArticleRetrievedEventArgs(ActiveUp.Net.Mail.Message article, int index)
        {
            this._message = article;
            this._index = index;
        }
        /// <summary>
        /// The retrieved message as a byte array.
        /// </summary>
        public ActiveUp.Net.Mail.Message Article
        {
            get
            {
                return this._message;
            }
        }
        /// <summary>
        /// The retrieved article's index on the remote server.
        /// </summary>
        public int MessageIndex
        {
            get
            {
                return this._index;
            }
        }
    }
    /// <summary>
    /// EventArgs used by the ArticleRetrieving event.
    /// </summary>
    [System.Serializable]
    public class ArticleRetrievingEventArgs : System.EventArgs
    {
        int _index;
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="index">The message to be retrieved's index.</param>
        public ArticleRetrievingEventArgs(int index)
        {
            this._index = index;
        }
        /// <summary>
        /// The index of the article to be retrieved on the remote server.
        /// </summary>
        public int MessageIndex
        {
            get
            {
                return this._index;
            }
        }
    }
    /// <summary>
    /// EventArgs used by the BodyRetrieved event.
    /// </summary>
    [System.Serializable]
    public class BodyRetrievedEventArgs : System.EventArgs
    {
        byte[] _data;
        int _index;
        /// <summary>
        /// Event
        /// </summary>
        /// <param name="data">The retrieved data as a byte array.</param>
        /// <param name="index">The index of the body retrieved.</param>
        public BodyRetrievedEventArgs(byte[] data, int index)
        {
            this._index = index;
            this._data = data;
        }
        /// <summary>
        /// The body retrieved from the remote server.
        /// </summary>
        public byte[] Data
        {
            get
            {
                return this._data;
            }
        }
        /// <summary>
        /// The index of the article body retrieved on the remote server.
        /// </summary>
        public int MessageIndex
        {
            get
            {
                return this._index;
            }
        }
    }
    /// <summary>
    /// EventArgs used by the BodyRetrieving event.
    /// </summary>
    [System.Serializable]
    public class BodyRetrievingEventArgs : System.EventArgs
    {
        int _index;
        /// <summary>
        /// Event
        /// </summary>
        /// <param name="index">The index of the body retrieved.</param>
        public BodyRetrievingEventArgs(int index)
        {
            this._index = index;
        }
        /// <summary>
        /// The index of the article body to be retrieved on the remote server.
        /// </summary>
        public int MessageIndex
        {
            get
            {
                return this._index;
            }
        }
    }*/
    /// <summary>
    /// EventArgs used by the MessageSending event.
    /// </summary>
#if !PocketPC
    [System.Serializable]
#endif
    public class MessageSendingEventArgs : System.EventArgs
    {
        Message _message;
        /// <summary>
        /// Event fired when a message is going to be sent.
        /// </summary>
        /// <param name="index">The message to be sent.</param>
        public MessageSendingEventArgs(Message message)
        {
            _message = message;
        }
        /// <summary>
        /// The message to be sent.
        /// </summary>
        public Message Message
        {
            get
            {
                return _message;
            }
        }
    }
    /// <summary>
    /// EventArgs used by the MessageSent event.
    /// </summary>
#if !PocketPC
    [System.Serializable]
#endif
    public class MessageSentEventArgs : System.EventArgs
    {
        Message _message;
        /// <summary>
        /// Event fired when a message has been sent.
        /// </summary>
        /// <param name="message">The message that has been sent.</param>
        public MessageSentEventArgs(Message message)
        {
            _message = message;
        }
        /// <summary>
        /// The message that has been sent.
        /// </summary>
        public Message Message
        {
            get
            {
                return _message;
            }
        }
    }

    /// <summary>
    /// EventArgs used by the NewMessage event.
    /// </summary>
#if !PocketPC
    [System.Serializable]
#endif
    public class NewMessageReceivedEventArgs : System.EventArgs
    {
        int _messageCount;
        /// <summary>
        /// Event fired when a new message received.
        /// </summary>
        /// <param name="messageCount">The number of new messages received.</param>
        public NewMessageReceivedEventArgs(int messageCount)
        {
            _messageCount = messageCount;
        }
        /// <summary>
        /// The number of new messages received.
        /// </summary>
        public int MessageCount
        {
            get
            {
                return _messageCount;
            }
        }
    }
}