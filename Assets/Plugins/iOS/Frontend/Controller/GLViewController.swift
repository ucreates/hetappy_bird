//======================================================================
// Project Name    : unity plugin
//
// Copyright © 2016 U-CREATES. All rights reserved.
//
// This source code is the property of U-CREATES.
// If such findings are accepted at any time.
// We hope the tips and helpful in developing.
//======================================================================
import UIKit
public class GLViewController : NSObject {
    public class func GetController() -> UIViewController {
        return UnityGetGLViewController()
    }
}