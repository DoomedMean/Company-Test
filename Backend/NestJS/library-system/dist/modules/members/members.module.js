"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.MemberModule = void 0;
const common_1 = require("@nestjs/common");
const typeorm_1 = require("@nestjs/typeorm");
const members_repository_1 = require("./members.repository");
const members_service_1 = require("./members.service");
const members_entity_1 = require("./members.entity");
let MemberModule = class MemberModule {
};
exports.MemberModule = MemberModule;
exports.MemberModule = MemberModule = __decorate([
    (0, common_1.Module)({
        imports: [typeorm_1.TypeOrmModule.forFeature([members_entity_1.Member])],
        providers: [members_service_1.MemberService, members_repository_1.MemberRepository],
        exports: [members_service_1.MemberService, members_repository_1.MemberRepository],
    })
], MemberModule);
//# sourceMappingURL=members.module.js.map