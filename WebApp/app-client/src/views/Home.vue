<template>
  <div class="home">
    <button @click="fetching">click</button>
    <pre>{{ dd }}</pre>
    <h1>{{tt}}</h1>
  </div>
</template>

<script>
// @ is an alias to /src

export default {
  async mounted() {
    const res = await fetch("/api/WeatherForecast");
    const data = await res.json();
    this.dd = data;
  },
  data() {
    return {
      dd: {},
      tt: null,
    };
  },
  name: "Home",
  methods: {
    async fetching() {
      const res = await fetch("/home/m2");
      const data = await res.json()
      console.log(data.name)
    },
  },
};
</script>
