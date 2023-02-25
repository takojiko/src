using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine.UI
{
    internal sealed class DummyMachineFacade : IMachinFacade
    {
        /// <summary>
        /// ファン停止時の内部温度を取得する
        /// </summary>
        /// <returns>ファン停止時の内部温度</returns>
        public int BoxInternalTemperatureFunStop()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 内部温度を取得
        /// </summary>
        /// <returns>内部温度</returns>
        public int BoxInternalTemperature()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ファンを停止した内部温度の前回値を取得
        /// </summary>
        /// <returns>ファンを停止した内部温度の前回値</returns>
        public int BoxInternalTemperatureFunStopInMemory()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 外部温度の取得
        /// </summary>
        /// <returns>外部温度</returns>
        public int BoxExternalTemperature()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 写真を撮る
        /// </summary>
        public void CameraTake()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ファンの回転数を取得
        /// </summary>
        /// <param name="fanId">ファンID</param>
        /// <returns>ファンの回転数</returns>
        public FanEntity FanSpin(int fanId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ファンを動かす
        /// </summary>
        /// <param name="fanId">ファンID</param>
        public void FanStart(int fanId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ファンを停止する
        /// </summary>
        /// <param name="fanId">ファンID</param>
        public void FanStop(int fanId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 電源ON
        /// </summary>
        public void PowerOn()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 電源OFF
        /// </summary>
        public void PowerOff()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// バックライトOFF
        /// </summary>
        public void BacklightOff()
        {
            throw new NotImplementedException();
        }
    }
}
