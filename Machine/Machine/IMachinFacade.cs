using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine
{
    public interface IMachinFacade
    {
        /// <summary>
        /// ファン停止時の内部温度を取得する
        /// </summary>
        /// <returns>ファン停止時の内部温度</returns>
        int BoxInternalTemperatureFunStop();

        /// <summary>
        /// 内部温度を取得
        /// </summary>
        /// <returns>内部温度</returns>
        int BoxInternalTemperature();

        /// <summary>
        /// ファンを停止した内部温度の前回値を取得
        /// </summary>
        /// <returns>ファンを停止した内部温度の前回値</returns>
        int BoxInternalTemperatureFunStopInMemory();

        /// <summary>
        /// 外部温度の取得
        /// </summary>
        /// <returns>外部温度</returns>
        int BoxExternalTemperature();

        /// <summary>
        /// 写真を撮る
        /// </summary>
        void CameraTake();

        /// <summary>
        /// ファンの回転数を取得
        /// </summary>
        /// <param name="fanId">ファンID</param>
        /// <returns>ファンの回転数</returns>
        FanEntity FanSpin(int fanId);

        /// <summary>
        /// ファンを動かす
        /// </summary>
        /// <param name="fanId">ファンID</param>
        void FanStart(int fanId);

        /// <summary>
        /// ファンを停止する
        /// </summary>
        /// <param name="fanId">ファンID</param>
        void FanStop(int fanId);

        /// <summary>
        /// 電源ON
        /// </summary>
        void PowerOn();

        /// <summary>
        /// 電源OFF
        /// </summary>
        void PowerOff();

        /// <summary>
        /// バックライトOFF
        /// </summary>
        void BacklightOff();
    }
}
