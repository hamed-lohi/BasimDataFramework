import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { NguCarouselModule } from "@ngu/carousel";

@NgModule({
    declarations: [],
    imports: [CommonModule, NguCarouselModule],
    exports: [NguCarouselModule],
})
export class SharedModule {}
