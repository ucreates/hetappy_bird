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
using Core.Entity;
using Service;
using Service.BizLogic;
using Service.Integration;
using Service.Integration.Table;
namespace Service.Strategy {
public sealed class PlayerClearStrategy : BaseStrategy {
    public override Response Update(Parameter parameter) {
        Response ret = new Response();
        ScoreBizLogic sbl = new ScoreBizLogic();
        sbl.Clear();
        ret.resultStatus = Response.ServiceStatus.SUCCESS;
        return ret;
    }
}
}
