﻿//======================================================================
// Project Name    : hetappy bird
//
// Copyright © 2016 U-CREATES. All rights reserved.
//
// This source code is the property of U-CREATES.
// If such findings are accepted at any time.
// We hope the tips and helpful in developing.
//======================================================================
using Core.Entity;
using Frontend.Component.Asset.Renderer.UI.Builder;
using Frontend.Component.State;
using UnityEngine;
namespace Frontend.Behaviour.State.UI.Shop
{
    public sealed class ConfirmModalDialogStayState : FiniteState<ShopCanvasBehaviour> {
    private ShopCanvasConfirmModalDialogBuilder builder {
        get;
        set;
    }
    public override void Create(Parameter paramter) {
        if (null == this.builder) {
            this.builder = new ShopCanvasConfirmModalDialogBuilder();
        } else {
            this.builder.Reset();
        }
        Transform roottrsfrm = this.owner.transform.Find("ConfirmModalDialog");
        this.builder
        .AddAlpha(1f)
        .AddTransform(roottrsfrm)
        .AddEnabled(true)
        .Update();
    }
}
}
