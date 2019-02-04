<script lang="tsx">
import { Component, Vue } from "vue-class-decorator";
import { CreateElement, VNode } from "vue";
import Config from "@/configs/navigation.config";

@Component
export default class Navigation extends Vue {
    private render(h: CreateElement): VNode {
        return <div class="navigation">
            <ul class="menus">
                <li class="menu" router-link="/">{Config.menus.home}</li>
                <li class="menu" router-link="/about">{Config.menus.about}</li>
            </ul>
        </div>;
    }
}
</script>

<style lang="less">
.navigation {
    height: 80px;
    display: flex;
    align-items: center;
    justify-content: center;
}

.menus {
    display: flex;

    & > li {
        list-style: none;
    }
}

.menu {
    & + & {
        margin-left: 22px;
    }
}
</style>
