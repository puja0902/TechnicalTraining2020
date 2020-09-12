"use strict";
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
Object.defineProperty(exports, "__esModule", { value: true });
exports.Customer = void 0;
var Customer = /** @class */ (function () {
    function Customer() {
        this.customerName = "";
        this.customerAmount = 0;
        this.customerName = "";
        this.customerAmount = 0;
    }
    Customer.prototype.Add = function () {
    };
    return Customer;
}());
exports.Customer = Customer;
var CustomerChild = /** @class */ (function (_super) {
    __extends(CustomerChild, _super);
    function CustomerChild() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    CustomerChild.prototype.Add = function () { };
    return CustomerChild;
}(Customer));
