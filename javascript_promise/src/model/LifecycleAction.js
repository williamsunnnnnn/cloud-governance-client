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
    define(['ApiClient'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.LifecycleAction = factory(root.CgClient.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';


  /**
   * Enum class LifecycleAction.
   * @enum {}
   * @readonly
   */
  var exports = {
    /**
     * value: "None"
     * @const
     */
    "None": "None",
    /**
     * value: "Extend"
     * @const
     */
    "Extend": "Extend",
    /**
     * value: "Delete"
     * @const
     */
    "Delete": "Delete",
    /**
     * value: "Archive"
     * @const
     */
    "Archive": "Archive",
    /**
     * value: "Policy"
     * @const
     */
    "Policy": "Policy",
    /**
     * value: "Unlock"
     * @const
     */
    "Unlock": "Unlock",
    /**
     * value: "Continue"
     * @const
     */
    "Continue": "Continue",
    /**
     * value: "Lock"
     * @const
     */
    "Lock": "Lock",
    /**
     * value: "Quota"
     * @const
     */
    "Quota": "Quota"  };

  /**
   * Returns a <code>LifecycleAction</code> enum value from a Javascript object name.
   * @param {Object} data The plain JavaScript object containing the name of the enum value.
   * @return {module:model/LifecycleAction} The enum <code>LifecycleAction</code> value.
   */
  exports.constructFromObject = function(object) {
    return object;
  }

  return exports;
}));


