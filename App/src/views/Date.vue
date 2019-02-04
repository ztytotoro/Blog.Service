<template>
  <Page>
    <div>{{GetDateName(DateType.meet)}}：{{meet.toLocaleDateString()}}</div>
    <div>{{GetDateName(DateType.bobo)}}{{bobo.toLocaleDateString()}}</div>
    <div>{{GetDateName(DateType.tell)}}{{tell.toLocaleDateString()}}</div>
    <div>{{GetDateName(DateType.birthday)}}{{birthday.toLocaleDateString()}}</div>
    <div>距离下一个{{GetDateName(DateType.meet)}}：{{GetDays(meet, nextMeet)}} 天纪念日 {{nextMeet.toLocaleDateString()}} 还有 {{GetDays(new Date(), nextMeet)}} 天</div>
    <div>距离下一个{{GetDateName(DateType.bobo)}}：{{GetDays(bobo, nextBobo)}} 天纪念日 {{nextBobo.toLocaleDateString()}} 还有 {{GetDays(new Date(), nextBobo)}} 天</div>
    <div>距离下一个{{GetDateName(DateType.tell)}}：{{GetDays(tell, nextTell)}} 天纪念日 {{nextTell.toLocaleDateString()}} 还有 {{GetDays(new Date(), nextTell)}} 天</div>
    <div>距离下一个{{GetDateName(DateType.birthday)}}：{{nextBirthday.toLocaleDateString()}} 还有 {{GetDays(new Date(), nextBirthday)}} 天</div>
    <div>下一个重要的日子: {{GetDateName(nextImportantDay.type)}}: {{nextImportantDay.date.toLocaleDateString()}}</div>
  </Page>
</template>

<script lang="ts">
import { Component, Vue } from "vue-class-decorator";
import Page from "@/components/Page.vue";

enum DateType {
  meet,
  bobo,
  tell,
  birthday
}

@Component({
  components: {
    Page
  }
})
export default class MyDate extends Vue {
  private meet: Date = new Date("2018-10-7");
  private bobo: Date = new Date("2018-12-2");
  private tell: Date = new Date("2018-12-3");
  private birthday: Date = new Date("1996-6-5");
  private DateType = DateType;

  public GetDays(d1: Date, d2: Date): number {
    return Math.floor((d2.getTime() - d1.getTime()) / (1000 * 60 * 60 * 24));
  }

  public NextDate(d: Date, days: number) {
    return new Date(d.getTime() + days * 1000 * 60 * 60 * 24);
  }

  public NextDay(d: Date) {
    const days = this.GetDays(d, new Date());
    if (days <= 400) {
      return Math.ceil(days / 100) * 100;
    } else if (days <= 520) {
      return 520;
    } else if (days <= 1200) {
      return Math.ceil(days / 100) * 100;
    } else if (days <= 1314) {
      return 1314;
    } else {
      return Math.ceil(days / 100) * 100;
    }
  }

  public get nextMeet() {
    return this.NextDate(this.meet, this.NextDay(this.meet));
  }

  public get nextTell() {
    return this.NextDate(this.tell, this.NextDay(this.tell));
  }

  public get nextBobo() {
    return this.NextDate(this.bobo, this.NextDay(this.bobo));
  }

  public get nextBirthday() {
    return new Date(
      new Date().getFullYear(),
      this.birthday.getMonth(),
      this.birthday.getDate()
    );
  }

  public get daysOfNextMeet() {
    return this.GetDays(new Date(), this.nextMeet);
  }

  public get daysOfNextTell() {
    return this.GetDays(new Date(), this.nextTell);
  }

  public get daysOfNextBirthday() {
    return this.GetDays(new Date(), this.nextBirthday);
  }

  public get daysOfNextBobo() {
    return this.GetDays(new Date(), this.nextBobo);
  }

  public get nextImportantDay() {
    const closestDate = Math.min(
      this.nextMeet.getTime(),
      this.nextBobo.getTime(),
      this.nextTell.getTime(),
      this.nextBirthday.getTime()
    );

    if (this.nextMeet.getTime() === closestDate) {
      return {
        date: this.nextMeet,
        type: DateType.meet,
        days: this.GetDays(this.meet, this.nextMeet)
      };
    } else if (this.nextBobo.getTime() === closestDate) {
      return {
        date: this.nextBobo,
        type: DateType.bobo,
        days: this.GetDays(this.bobo, this.nextBobo)
      };
    } else if (this.nextTell.getTime() === closestDate) {
      return {
        date: this.nextTell,
        type: DateType.tell,
        days: this.GetDays(this.tell, this.nextTell)
      };
    } else {
      return {
        date: this.nextBirthday,
        type: DateType.birthday
      };
    }
  }

  public GetDateName(type: DateType) {
    switch (type) {
      case DateType.meet:
        return "相识纪念日";
      case DateType.bobo:
        return "啵啵纪念日";
      case DateType.tell:
        return "表白纪念日";
      case DateType.birthday:
        return "她的生日";
      default:
        return "";
    }
  }
}
</script>
