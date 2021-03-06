/**
 * Cloud Governance Api
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 *
 * OpenAPI Generator version: 4.2.2
 *
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['ApiClient', 'model/TemporaryPermissionRequestSetting', 'model/WelcomeEmailSettings'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./TemporaryPermissionRequestSetting'), require('./WelcomeEmailSettings'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.GrantPermissionModel = factory(root.CgClient.ApiClient, root.CgClient.TemporaryPermissionRequestSetting, root.CgClient.WelcomeEmailSettings);
  }
}(this, function(ApiClient, TemporaryPermissionRequestSetting, WelcomeEmailSettings) {
  'use strict';



  /**
   * The GrantPermissionModel model module.
   * @module model/GrantPermissionModel
   * @version 1.0
   */

  /**
   * Constructs a new <code>GrantPermissionModel</code>.
   * @alias module:model/GrantPermissionModel
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>GrantPermissionModel</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/GrantPermissionModel} obj Optional instance to populate.
   * @return {module:model/GrantPermissionModel} The populated <code>GrantPermissionModel</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('permissionDurationSettings')) {
        obj['permissionDurationSettings'] = TemporaryPermissionRequestSetting.constructFromObject(data['permissionDurationSettings']);
      }
      if (data.hasOwnProperty('welcomeEmailSettings')) {
        obj['welcomeEmailSettings'] = WelcomeEmailSettings.constructFromObject(data['welcomeEmailSettings']);
      }
    }
    return obj;
  }

  /**
   * @member {module:model/TemporaryPermissionRequestSetting} permissionDurationSettings
   */
  exports.prototype['permissionDurationSettings'] = undefined;
  /**
   * @member {module:model/WelcomeEmailSettings} welcomeEmailSettings
   */
  exports.prototype['welcomeEmailSettings'] = undefined;



  return exports;
}));


