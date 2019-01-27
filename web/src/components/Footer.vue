<script lang="tsx">
import { Component, Vue } from "vue-class-decorator";
import { CreateElement, VNode } from "vue";
import Config from "@/configs/footer.config";

@Component
export default class Footer extends Vue {
    private render(h: CreateElement): VNode {
        return <div class="footer">
            <span class="author">Copyright - {Config.author}@{new Date().getFullYear()}丨{Config.email}</span>
        </div>;
    }
}
</script>

<style lang="less">
.footer {
    height: 80px;
    display: flex;
    align-items: center;
    justify-content: center;
}
</style>
