﻿using System;

namespace NDDD.Domain.Exceptions
{
    /// <summary>
    /// Fake例外
    /// </summary>
    public sealed class FakeException : ExceptionBase
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="message">メッセージ</param>
        /// <param name="exception">元になった例外</param>
        public FakeException(string message, Exception exception)
            : base(message, exception)
        {
        }

        /// <summary>
        /// 例外区分
        /// </summary>
        public override ExceptionKind Kind => ExceptionKind.Info;
    }
}
