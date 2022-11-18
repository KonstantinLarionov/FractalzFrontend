<template>
  <div class="news-wrap" id="newsSpace">
    <div class="row news-controls">
    </div>
    <div v-for="newsContent in newsContents" :key="newsContent.$id">
      <news-element :news-name="newsContent.name" :news-type="newsContent.type" :news-text="newsContent.text"></news-element>
    </div>
  </div>
</template>
<script>

import NewsElement from "../elements/NewsElement";
import Vue from "vue";

Vue.component ('news-element', NewsElement)
export default {
  name: "NewsPage",
  date() {
    return {
      newsContents: [],
    }
  },
  mounted: async function () {
    this.newsContents = [];
    this.getNews();
  },
  methods: {
    getNews: function () {
      var arr =[
        {
          id: 0,
          name:'Заголовок новости',
          type: 'Спорт',
          text: '11111 111',
        },
        {
          id: 0,
          name:'Заголовок новости',
          type: 'Спорт',
          text: '11111 111',
        },
        {
          id: 0,
          name:'Заголовок новости',
          type: 'Спорт',
          text: '11111 111',
        }
      ];

      for (let j in arr)
      {
        this.$set(this.newsContents, j, arr[j])
      }
      this.$forceUpdate();
    },
  }
}
</script>

<style scoped>

</style>
