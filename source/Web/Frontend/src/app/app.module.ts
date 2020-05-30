import { HTTP_INTERCEPTORS, HttpClientModule } from "@angular/common/http";
import { ErrorHandler, NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { AppLayoutsModule } from "src/app/layouts/layouts.module";
import { AppComponent } from "./app.component";
import { AppRoutingModule } from "./app.routing.module";
import { AppErrorHandler } from "./core/handlers/error.handler";
import { AppHttpInterceptor } from "./core/interceptors/http.interceptor";
import { AppHomeComponent } from "./views/main/home/home.component";
import { SharedModule } from "./shared.module";

@NgModule({
    bootstrap: [AppComponent],
    declarations: [AppComponent, AppHomeComponent],
    imports: [
        BrowserModule,
        HttpClientModule,
        AppLayoutsModule,
        AppRoutingModule,
        SharedModule,
    ],
    providers: [
        { provide: ErrorHandler, useClass: AppErrorHandler },
        {
            provide: HTTP_INTERCEPTORS,
            useClass: AppHttpInterceptor,
            multi: true,
        },
    ],
})
export class AppModule {}
