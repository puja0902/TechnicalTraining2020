"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Customer_1 = require("./Customer");
var custobj = new Customer_1.Customer();
custobj.Add();
var Client = /** @class */ (function () {
    function Client() {
        this.custobj1 = new Customer_1.Customer();
        //custobj1.Add();
    }
    return Client;
}());
