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
using Service.BizLogic;
using Service.Strategy;
namespace Service {
public sealed class PlayerService : BaseService {
    public PlayerService() {
        this.strategyDictionary.Add("score", new PlayerScoreStrategy());
        this.strategyDictionary.Add("clear", new PlayerClearStrategy());
        this.strategyDictionary.Add("commit", new PlayerCommitStrategy());
    }
}
}
