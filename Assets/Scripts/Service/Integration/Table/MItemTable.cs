﻿//======================================================================
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
using Service.Integration.Schema;
namespace Service.Integration.Table {
public sealed class MItemTable : BaseTable {
    public string name {
        get;
        set;
    }
    public int price {
        get;
        set;
    }
    public MItemTable() : this(string.Empty, 0) {}
    public MItemTable(string name, int price) {
        this.name = name;
        this.price = price;
    }
    public override BaseTable Clone() {
        return base.MemberwiseClone() as MItemTable;
    }
}
}
