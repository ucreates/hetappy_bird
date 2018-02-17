//======================================================================
// Project Name    : hetappy bird
//
// Copyright © 2016 U-CREATES. All rights reserved.
//
// This source code is the property of U-CREATES.
// If such findings are accepted at any time.
// We hope the tips and helpful in developing.
//======================================================================
using UnityEngine;
using System.Collections;
using Service.Strategy;
using Service.BizLogic;
namespace Service {
public sealed class StatsService : BaseService {
    public StatsService() {
        this.strategyDictionary.Add("player", new PlayerStatsStrategy());
        this.strategyDictionary.Add("ranking", new RankingStatsStrategy());
        this.strategyDictionary.Add("result", new ResultStatsStrategy());
    }
}
}
