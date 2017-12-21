import { NgModule } from '@angular/core';
import { CommonModule } from "@angular/common";

import {
     SidebarComponent
    } from './';

@NgModule({
    imports: [
        CommonModule
    ],
    exports: [
        SidebarComponent,
    ],
    declarations: [
        SidebarComponent,
    ],
    providers: [],
})
export class ComponentModule { }
    