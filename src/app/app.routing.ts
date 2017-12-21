import { RouterModule, Routes } from "@angular/router";
import { ModuleWithProviders } from "@angular/core";

import { HomeComponent, NotesComponent } from "./route";

const APP_ROUTES: Routes = [
    { path: "", component: HomeComponent },
    { path: "/notes", component: NotesComponent}
];

export const ROUTING: ModuleWithProviders = RouterModule.forRoot(APP_ROUTES);