using System;
using System.Collections.Generic;

namespace QuantCSharp.ProxyCTP
{
    /// <summary>
    /// 是一个报单价格条件类型
    /// </summary>
    internal struct TFtdcOrderPriceTypeType
    {
        internal const sbyte THOST_FTDC_OPT_AnyPrice = 49; //'1'
        internal const sbyte THOST_FTDC_OPT_LimitPrice = 50;//'2'
        internal const sbyte THOST_FTDC_OPT_BestPrice = 51;//'3'
    }

    /// <summary>
    /// 是一个投机套保标志类型
    /// </summary>
    internal struct TFtdcHedgeFlagEnType
    {
        ///投机
        internal const sbyte THOST_FTDC_HFEN_Speculation = 49; //'1'
        ///套利
        internal const sbyte THOST_FTDC_HFEN_Arbitrage = 50;//'2'
        ///套期保值
        internal const sbyte THOST_FTDC_HFEN_Hedge = 51;//'3'
    }

    /// <summary>
    /// 是一个成交量类型类型
    /// </summary>
    internal struct TFtdcVolumeConditionType
    {
        ///任何数量
        internal const sbyte THOST_FTDC_VC_AV = 49; //'1'
        ///最小数量
        internal const sbyte THOST_FTDC_VC_MV = 50;//'2'
        ///全部数量
        internal const sbyte THOST_FTDC_VC_CV = 51;//'3'
    }

    /// <summary>
    /// 是一个触发条件类型
    /// </summary>
    internal struct TFtdcContingentConditionType
    {
        ///立即
        internal const sbyte THOST_FTDC_CC_Immediately = 49; //'1'
        ///止损
        internal const sbyte THOST_FTDC_CC_Touch = 50;//'2'
        ///止赢
        internal const sbyte THOST_FTDC_CC_TouchProfit = 51;//'3'
        ///预埋单
        internal const sbyte THOST_FTDC_CC_ParkedOrder = 52;//'4'
    }

    /// <summary>
    /// 是一个强平原因类型
    /// </summary>
    internal struct TFtdcForceCloseReasonType
    {
        ///非强平
        internal const sbyte THOST_FTDC_FCC_NotForceClose = 48; //'0'
        ///资金不足
        internal const sbyte THOST_FTDC_FCC_LackDeposit = 49; //'1'

        ///持仓非整数倍
        internal const sbyte THOST_FTDC_FCC_NotMultiple = 52;//'4'
        ///违规
        internal const sbyte THOST_FTDC_FCC_Violation = 53;//'5'
        ///其它
    }

    /// <summary>
    /// 是一个交易所编号类型
    /// </summary>
    internal struct TFtdcExchangeIDTypeType
    {
        ///上海期货交易所
        internal const char THOST_FTDC_EIDT_SHFE = 'S';
        ///郑州商品交易所
        internal const char THOST_FTDC_EIDT_CZCE = 'Z';
        ///大连商品交易所
        internal const char THOST_FTDC_EIDT_DCE = 'D';
        ///中国金融期货交易所
        internal const char THOST_FTDC_EIDT_CFFEX = 'J';
        ///上海国际能源交易中心股份有限公司
        internal const char THOST_FTDC_EIDT_INE = 'N';
    }

    internal struct TThostFtdcActionFlagType
    {
        ///删除
        internal const sbyte THOST_FTDC_AF_Delete = 48; //'0'
        ///修改
        internal const sbyte THOST_FTDC_AF_Modify = 51; //'3'
    }

    /// <summary>
    /// 是一个报单提交状态类型
    /// </summary>
    public struct TThostFtdcOrderSubmitStatusType
    {
        //已经提交
        internal const sbyte THOST_FTDC_OSS_InsertSubmitted = 48;  //'0'
        //撤单已经提交
        internal const sbyte THOST_FTDC_OSS_CancelSubmitted = 49; //'1'
        //已经接受
        internal const sbyte THOST_FTDC_OSS_Accepted = 51; //'3'
        //报单已经被拒绝
        internal const sbyte THOST_FTDC_OSS_InsertRejected = 52; //'4'
        //撤单已经被拒绝
        internal const sbyte THOST_FTDC_OSS_CancelRejected = 53;// '5'
    }


    /// <summary>
    /// 是一个报单操作状态类型
    /// </summary>
    public struct TFtdcOrderActionStatusType
    {
        //已经提交
        internal const sbyte THOST_FTDC_OAS_Submitted = 97;// 'a'
                                                           //已经接受
        internal const sbyte THOST_FTDC_OAS_Accepted = 98; //'b'
                                                           //已经被拒绝
        internal const sbyte THOST_FTDC_OAS_Rejected = 99;//'c'
    }

}
