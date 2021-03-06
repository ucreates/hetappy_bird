//======================================================================
// Project Name    : hetappy bird
//
// Copyright © 2016 U-CREATES. All rights reserved.
//
// This source code is the property of U-CREATES.
// If such findings are accepted at any time.
// We hope the tips and helpful in developing.
//======================================================================
using System.Collections.Generic;
using Core.Entity;
using Frontend.Component.Asset.Renderer.UI.Builder;
using Frontend.Component.State;
using Service;
using UnityEngine;
namespace Frontend.Behaviour.State.UI.Shop
{
    public sealed class ListModalDialogStayState : FiniteState<ShopCanvasBehaviour> {
    private ShopCanvasListModalDialogBuilder builder {
        get;
        set;
    }
    public override void Create() {
        if (null == this.builder) {
            this.builder = new ShopCanvasListModalDialogBuilder();
        } else {
            this.builder.Reset();
        }
        Response response =  ServiceGateway.GetInstance().Request("service://shop/list").Get();
        Canvas canvas = this.owner.GetComponent<Canvas>();
        if (null != canvas) {
            canvas.enabled = true;
        }
        Transform trsfrm = this.owner.transform.Find("ListModalDialog");
        List<string> itemIdList = response.Get<List<string>>("itemidlist");
        this.builder
        .AddItemList(itemIdList)
        .AddTransform(trsfrm)
        .AddAlpha(1f)
        .Update();
    }
}
}
