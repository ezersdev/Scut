﻿/****************************************************************************
Copyright (c) 2013-2015 scutgame.com

http://www.scutgame.com

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZyGames.Framework.Game.Service
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class JsonAction : BaseStruct
    {
        /// <summary>
        /// 
        /// </summary>
        protected Encoding encoding = Encoding.UTF8;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aActionId"></param>
        /// <param name="actionGetter"></param>
        protected JsonAction(int aActionId, ActionGetter actionGetter)
            : base(aActionId, actionGetter)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="response"></param>
        public override void WriteResponse(BaseGameResponse response)
        {
            var message = BuildResponsePack();
            response.Write(encoding.GetBytes(message));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected abstract string BuildResponsePack();
    }
}