using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WhiteBit.Net.Models.Enums
{
    /// <summary>
    /// The side of an order
    /// </summary>
    public enum WhiteBitOrderSide
    {
        /// <summary>
        /// Buy
        /// </summary>
        [EnumMember(Value = "buy")]
        Buy = 2,
        /// <summary>
        /// Sell
        /// </summary>
        [EnumMember(Value = "sell")]
        Sell = 1
    }
    /// <summary>
    /// The type of the order
    /// </summary>
    public enum WhiteBitOrderType
    {
        [EnumMember(Value = "limit")]
        Limit = 1,
        [EnumMember(Value = "market")]
        Market = 2,
        [EnumMember(Value = "stop limit")]
        StopLimit = 3,
        [EnumMember(Value = "stop market")]
        StopMarket = 4,
        ConditionalLimit = 5,
        ConditionalMarket = 6,
        MarginLimit = 7,
        MarginMarket = 8,
        MarginTriggerStopLimit = 9,
        MarginTriggerStopMarket = 10,
        [EnumMember(Value = "stock market")]
        StockMarket
    }
    
    /// <summary>
    /// If new order instantly matches an order from orderbook,
    /// then you will receive only one message with update event ID equal to 3.
    /// </summary>
    public enum SocketOrderUpdateEventType
    {
        NewOrder = 1,
        UpdateOrder = 2,
        /// <summary>
        /// Finish order (cancel or execute)
        /// </summary>
        FinishOrder = 3
    }

    public enum WhiteBitProductType
    {
        Futures,
        Perpetual,
        Options

    }
    public enum TraderRole
    {
        Maker = 1,
        Taker = 2
    }
    public enum SocketErrorCode
    {
        InvalidArgument = 1,
        InternalError = 2,
        ServiceUnavailable = 3,
        MethodNotFound = 4,
        ServiceTimeout = 5
    }
    public enum SubscriptionStatus
    {
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "failed")]
        Failed
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SocketOutgoingMethod
    {
        [EnumMember(Value = "authorize")]
        Authorize,

        [EnumMember(Value = "balanceSpot_request")]
        BalanceSpotRequest,

        [EnumMember(Value = "balanceSpot_subscribe")]
        BalanceSpotSubscribe,

        [EnumMember(Value = "balanceSpot_unsubscribe")]
        BalanceSpotUnsubscribe,

        [EnumMember(Value = "balanceMargin_request")]
        BalanceMarginRequest,

        [EnumMember(Value = "balanceMargin_subscribe")]
        BalanceMarginSubscribe,

        [EnumMember(Value = "balanceMargin_unsubscribe")]
        BalanceMarginUnsubscribe,

        [EnumMember(Value = "ordersPending_request")]
        ActiveOrdersRequest,

        [EnumMember(Value = "ordersPending_subscribe")]
        ActiveOrdersSubscribe,

        [EnumMember(Value = "ordersPending_unsubscribe")]
        ActiveOrdersUnsubscribe,

        [EnumMember(Value = "ordersExecuted_request")]
        ExecutedOrdersRequest,

        [EnumMember(Value = "ordersExecuted_subscribe")]
        ExecutedOrdersSubscribe,

        [EnumMember(Value = "ordersExecuted_unsubscribe")]
        ExecutedOrdersUnsubscribe,

        [EnumMember(Value = "deals_request")]
        UserTradesRequest,

        [EnumMember(Value = "deals_subscribe")]
        UserTradesSubscribe,

        [EnumMember(Value = "deals_unsubscribe")]
        UserTradesUnsubscribe,

        [EnumMember(Value = "candles_request")]
        CandlesRequest,

        [EnumMember(Value = "candles_subscribe")]
        CandlesSubscribe,

        [EnumMember(Value = "candles_unsubscribe")]
        CandlesUnsubscribe,

        [EnumMember(Value = "lastprice_request")]
        LastpriceRequest,

        [EnumMember(Value = "lastprice_subscribe")]
        LastpriceSubscribe,

        [EnumMember(Value = "lastprice_unsubscribe")]
        LastpriceUnsubscribe,

        [EnumMember(Value = "market_request")]
        MarketStatisticRequest,

        [EnumMember(Value = "market_subscribe")]
        MarketStatisticSubscribe,

        [EnumMember(Value = "market_unsubscribe")]
        MarketStatisticUnsubscribe,

        [EnumMember(Value = "marketToday_request")]
        TickerRequest,

        [EnumMember(Value = "marketToday_subscribe")]
        TickerSubscribe,

        [EnumMember(Value = "marketToday_unsubscribe")]
        TickerUnsubscribe,

        [EnumMember(Value = "trades_request")]
        PublicTradesRequest,

        [EnumMember(Value = "trades_subscribe")]
        PublicTradesSubscribe,

        [EnumMember(Value = "trades_unsubscribe")]
        PublicTradesUnsubscribe,

        [EnumMember(Value = "depth_request")]
        OrderBookRequest,

        [EnumMember(Value = "depth_subscribe")]
        OrderBookSubscribe,

        [EnumMember(Value = "depth_unsubscribe")]
        OrderBookUnsubscribe,
    }
    public enum SocketIncomeMethod
    {
        [EnumMember(Value = "balanceSpot_update")]
        BalanceSpot,

        [EnumMember(Value = "balanceMargin_update")]
        BalanceMargin,

        [EnumMember(Value = "ordersPending_update")]
        ActiveOrders,

        [EnumMember(Value = "ordersExecuted_update")]
        ExecutedOrders,

        [EnumMember(Value = "deals_update")]
        UserTrades,

        [EnumMember(Value = "candles_update")]
        Candles,

        [EnumMember(Value = "lastprice_update")]
        Lastprice,

        [EnumMember(Value = "market_update")]
        MarketStatistic,

        [EnumMember(Value = "marketToday_update")]
        Ticker,

        [EnumMember(Value = "trades_update")]
        PublicTrades,

        [EnumMember(Value = "depth_update")]
        OrderBook,
    }
}