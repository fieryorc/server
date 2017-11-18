﻿using SuperSocket.SocketBase;

using Libraries.helpers.package;


namespace Game
{

    public class PlayerSession : AppSession<PlayerSession, Package>
    {

        public string PlayerName { get; internal set; }
        public string Password { get; internal set; }



        /// <summary>
        /// Override called when [session closed].
        /// </summary>
        /// <param name="reason">The reason.</param>
        protected override void OnSessionClosed(CloseReason reason)
        {

            if (Logger.IsInfoEnabled)
                Logger.Info($"Game::OnSessionClosed - Session closed. Reason: ({reason})");

        }

        /// <summary>
        /// Handle Unknown request
        /// </summary>
        /// <param name="content"></param>
        protected override void HandleUnknownRequest(Package content)
        {

            if (Logger.IsDebugEnabled)
                Logger.Debug($"Game::HandleUnknownRequest - Unknown package. Content: {content}");

        }        

    }

}
