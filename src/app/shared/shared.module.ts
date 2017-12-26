import { NgModule, ModuleWithProviders } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { Routes, RouterModule } from '@angular/router';

@NgModule({
    imports: [
        CommonModule,
        RouterModule,
    ],
    declarations: [
    ],
    exports: [
        CommonModule,
        FormsModule,
    ]
})
export class SharedModule {

    static forRoot(): ModuleWithProviders {
        return {
            ngModule: SharedModule,
            providers: []
        };
    }
}


@NgModule({
    exports: [SharedModule],
    providers: []
})
export class SharedRootModule { }